# -*- coding: utf8 -*-

# socket 과 select 모듈 임포트
from socket import *
from select import *
import sys
import pyaudio
import wave
<<<<<<< HEAD
from time import ctime

HOST = ''
PORT = 8001
ADDR = (HOST, PORT)
BUFSIZE = 1024

FORMAT = pyaudio.paInt16
CHANNELS = 2
RATE = 44100


# TCP socket
serverSocket = socket(AF_INET, SOCK_STREAM)

# binding
serverSocket.bind(ADDR)

# listen, roomsize = 10
serverSocket.listen(10)
connection_list = [serverSocket]

print('==============================================')
print('START SIX SENSE SERVER... port: %s' % str(PORT))
print('==============================================')

# 무한 루프를 시작
while connection_list:
    try:
        print('[INFO] waiting request...')

        # select 로 요청을 받고, 10초마다 블럭킹을 해제하도록 함
        read_socket, write_socket, error_socket = select(connection_list, [], [], 10)

        for sock in read_socket:
            # 새로운 접속
            if sock == serverSocket:
                clientSocket, addr_info = serverSocket.accept()
                connection_list.append(clientSocket)
                print('[INFO][%s] new client(%s) is connected to server...' % (ctime(), addr_info[0]))



            # 접속한 사용자(클라이언트)로부터 새로운 데이터 받음
            else:
                data = sock.recv(BUFSIZE)
                print('[INFO][%s] receive data from client - %s' % (ctime(), addr_info[0],))
                print data
                if data == "START":
                    frames = []
                    print "start..."

                    while(True):
                        data = sock.recv(BUFSIZE)
                        if data == "END":
                            break
                        else:
                            frames.append(data)

                    #end appending
                    print ("making wave file form audio stream")
                    WAVE_OUTPUT_FILENAME = ("%s" % (addr_info[0],))
                    wf = wave.open(WAVE_OUTPUT_FILENAME + ".wav", 'wb')

                    wf.setnchannels(CHANNELS)
                    wf.setsampwidth(p.get_sample_size(FORMAT))
                    wf.setframerate(RATE)
                    wf.writeframes(b''.join(frames))
                    wf.close()

                    # clear all the frames
                    del frames[:]

                else:
                    connection_list.remove(sock)
                    sock.close()
                    print('[INFO][%s] connection closed from client - %s' % ctime(), addr_info[0])

    except KeyboardInterrupt:
        # 부드럽게 종료하기
        serverSocket.close()
        sys.exit()
=======
import socket
from threading import Thread


def audioStream():
    
    FORMAT = pyaudio.paInt16
    CHUNK = 3584 # or BUFFUR
    CHANNELS = 2
    RATE = 44100

    frames = []

    p = pyaudio.PyAudio()
    """stream = p.open(format=FORMAT,
                    channels=CHANNELS,
                    rate=RATE,
                    output=True,
                    frames_per_buffer=CHUNK, )
    """

    while True:
 
        udp = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
        udp.bind(('',8001))

        data, addr = udp.recvfrom(CHUNK*CHANNELS*2)



        if data != "END":
            frames.append(data)
        
        elif data == "END":

            WAVE_OUTPUT_FILENAME = ("%s" % (addr,))
            wf= wave.open(WAVE_OUTPUT_FILENAME+".wav", 'wb')
            wf.setnchannels(CHANNELS)
            wf.setsampwidth(p.get_sample_size(FORMAT))
            wf.setframerate(RATE)
            wf.writeframes(b''.join(frames))
            wf.close()

            frames = ['0']*len(frames)



        else:
            print "unkwon data"
        
        udp.close()
    p.terminate()

if __name__ == "__main__":

    T_audioStream = Thread(target = audioStream,)
    T_audioStream.setDaemon(True)
    T_audioStream.start()
    T_audioStream.join()

>>>>>>> cef0a351fcc2f5feedb1887754c970bb0dbe7f13
