
from socket import *
from select import *
import sys
import pyaudio
import wave
from time import ctime

HOST = ''
PORT = 8001
ADDR = (HOST, PORT)
BUFSIZE = 1024

FORMAT = pyaudio.paInt16
CHANNELS = 1
RATE = 44100

def doOperation(data, addr):
    """
    operation table

    START : client send audio stream to server and send "END" to notice final chunk(buffer)
    NEW_CLASS : client sen audio stream to server for request about new audio class label

    """
    if (data == 'START') | (data == 'START\n'):

        frames = []
        print "start..."
        while (True):
            data = sock.recv(BUFSIZE)
            print data
            if (data == "END") | (data == "END\n"):
                break
            else:
                frames.append(data)

        wave_output_filename = ("%s" % (addr,))
        MakeAudioFileFromList(frames, wave_output_filename)

    elif (data == "NEW_CLASS") | (data == "NEW_CLASS\n"):

        frames = []
        print "start..."
        while (True):
            data = sock.recv(BUFSIZE)
            if (data == "END") | (data == "END\n"):
                break
            else:
                frames.append(data)

        newClassLabel = sock.recv(BUFSIZE)
        wave_output_filename = ("userRequestLabelDir/%s" % (newClassLabel,))
        MakeAudioFileFromList(frames, wave_output_filename)

    #elif data == "BUG_REPORT" | data == "BUG_REPORT\n":



    # exception case: close the connection
    else:
        connection_list.remove(sock)
        sock.close()
        print('[INFO][%s] connection closed from client - %s' % ctime(), addr_info[0])


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
                    print('[INFO][%s] receive data from client - %s' % (ctime(), addr_info[0],))
                    print data

                    doOperation(data, addr_info[0])

        except KeyboardInterrupt:
            # good way to terminate
            serverSocket.close()
            sys.exit()

