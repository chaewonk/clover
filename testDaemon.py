# -*- coding:utf-8 -*-


import wave
from select import *
from socket import *
from time import ctime

import pyaudio
from pyfcm import FCMNotification


push_service = FCMNotification(api_key="AAAAkXdjqxM:APA91bHgGK9xOi7tTf0ch6tOoxU30hNevDohrkNcyUhLuiHqNgifO4jDDYUSgrVCS_h5VB9JUV1ffxRFa5x-4pshglFyoO2wFtTfT2yfA5UkDIP5iyFfwN1_Jf4fyhQsVd4Kr7_TUZGM")


registration_id ="e76bV14MH3c:APA91bH8ypElx8UqSMwmy5hENsBMmHgEZcxRR0LwDdvuEPWkYrlOWKZ7se_yBdPgJCBTBcmTciGvwWtdBWWQPEDI_vbm3Cnzn-FeW5B4lwnPGWAbJiPlhw11zAgmt1tNUQFndWWIaf03"

data_message = {
        "Nick" : "Mario",
        "body" : "great match!",
        "Room" : "PortugalVSDenmark"
        }


message_title = "title"
message_body = "body"

#User-Define libraries
from S2 import *


HOST = ''
PORT = 8001
ADDR = (HOST, PORT)
BUFSIZE = 1024
BUFSIZE2 = 4096

FORMAT = pyaudio.paInt16
CHANNELS = 1
RATE = 44100

def doOperation(data, addr, sock):
    """
    operation table

    START : client send audio stream to server and send "END" to notice final chunk(buffer)
    NEW_CLASS : client sen audio stream to server for request about new audio class label

    """
    if (data == 'START') | (data == 'START\n'):

        wave_output_filename = ("%s" % (addr,))
        f=open(wave_output_filename+'.wav', 'wb')

        print "start..."

        data = sock.recv(BUFSIZE2)
        total_file_size = int(data.split('\n')[0])
        print "totial file size: %s" %(total_file_size,)


        data = data.split('\n')[1:]
        data = ''.join(data)
        f.write(data)

        remain_size = total_file_size
        while(remain_size>BUFSIZE2):

            data = sock.recv(BUFSIZE2)
            remain_size = remain_size - len(data)
            print len(data)
            f.write(data)

        data = sock.recv(BUFSIZE2)
        remain_size = remain_size - len(data)
        print len(data)
        f.write(data)
        
        if wave_output_filename != "":
            cf = s2(wave_output_filename+".wav")
            
            message_body = cf

            push_service.notify_single_device(registration_id=registration_id,
                    message_body=message_body,
                    data_message=data_message)      

            
            
            
            sock.send(cf)
            print cf
        else:
            sock.send('err')
        # extract audio label by using deep learning
        #sock.send('ACK: ANDROID')
        #print 'ACK: ANDROID'

        f.close()
        #os.remove(wave_output_filename+"*")

    #elif (data == "TIZEN") | (data == "TIZEN\n"):
    elif 'TIZEN' in data:
        wave_output_filename = ("%s" % (addr,))
        f=open(wave_output_filename+'.wav', 'wb')

        print ("start form tizen...")

        #data = sock.recv(BUFSIZE)
        total_file_size = sock.recv(50)
        total_file_size = int(total_file_size.split('/')[0])
        print "totial file size: %s" %(total_file_size,)

        remain_size = total_file_size
        while(remain_size>BUFSIZE):

            data = sock.recv(BUFSIZE)
            remain_size = remain_size - len(data)
            print len(data)
            f.write(data)

        data = sock.recv(BUFSIZE)
        remain_size = remain_size - len(data)
        print len(data)
        f.write(data)

        # extract audio label by using deep learning
        if wave_output_filename != "":
            cf = s2(wave_output_filename+".wav")
            sock.send(cf)
            print cf
        else:
            sock.send('err')

        f.close()
        #os.remove(wave_output_filename+"*")

    elif (data == "NEW_CLASS") | (data == "NEW_CLASS\n"):

        frames = []
        print "start..."
        while (True):
            data = sock.recv(BUFSIZE)
            if (data == "END") | (data == "END\n"):
                print 'END'
                break
            else:
                frames.append(data)

        newClassLabel = sock.recv(BUFSIZE)
        wave_output_filename = ("userRequestLabelDir/%s" % (newClassLabel,))
        MakeAudioFileFromList(frames, wave_output_filename)


    #elif (data == "ADD_USER") | (data == "ADD_USER\n"):
    #elif data == "BUG_REPORT" | data == "BUG_REPORT\n":

    elif len(data) == 0:
	print('[INFO][%s] socket is closed frome the client -%s' % (ctime(), addr_info[0]))


    else:
        print('[INFO][%s] unknown data from client - %s' % (ctime(), addr_info[0]))
        print data


def MakeAudioFileFromList(list, filename):

    p = pyaudio.PyAudio()

    print ("making wave file form audio stream")

    wf = wave.open(filename + ".wav", 'wb')
    wf.setnchannels(CHANNELS)
    wf.setsampwidth(p.get_sample_size(FORMAT))
    wf.setframerate(RATE)
    wf.writeframes(b''.join(list))
    wf.close()

    p.terminate()

if __name__ == "__main__":

    # TCP socket
    serverSocket = socket(AF_INET, SOCK_STREAM)
    # binding
    serverSocket.bind(ADDR)
    # listen, room size = 10
    serverSocket.listen(10)
    connection_list = [serverSocket]

    print('==============================================')
    print('START SIX SENSE SERVER... port: %s' % str(PORT))
    print('==============================================')


    while connection_list:
        try:
            print('[INFO] waiting request...')
            
            #print s2("dog.wav")


            # selection method,
            read_socket, write_socket, error_socket = select(connection_list, [], [], 10)

            for sock in read_socket:
                # new connection
                if sock == serverSocket:
                    clientSocket, addr_info = serverSocket.accept()
                    connection_list.append(clientSocket)
                    print('[INFO][%s] new client(%s) is connected to server...' % (ctime(), addr_info[0]))


                # receive data form client
                else:
                    data = sock.recv(BUFSIZE)
                    if data:
                        print('[INFO][%s] receive data from client - %s' % (ctime(), addr_info[0],))
			print data

                        doOperation(data, addr_info[0], sock)

                        connection_list.remove(sock)
                        sock.close()
                    else:
                        print('[INFO][%s] receive null data from client - %s' % (ctime(), addr_info[0],))
                        connection_list.remove(sock)
                        sock.close()

        except KeyboardInterrupt:
            # good way to terminate
            serverSocket.close()
            sys.exit()
