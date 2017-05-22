package com.example.myapplication;

import android.util.Log;

import java.io.BufferedInputStream;
import java.io.BufferedWriter;
import java.io.DataOutputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.OutputStreamWriter;
import java.io.PrintWriter;
import java.net.Socket;

/**
 * Created by 김채원 on 2017-05-20.
 */
public class FileSend {
    private Socket s;
    private BufferedWriter buffSend;
    private final static int port=8001;
    private final static String server ="104.198.87.16";
    String str="START";
    DataOutputStream dos;
    Long FileSize;
    public FileSend(String host, int port, String file) {
        try {
            s = new Socket(host, port);
            dos = new DataOutputStream(s.getOutputStream());
            byte[] arr1 = str.getBytes();
            dos.write(arr1);
            //dos.flush();
            sendFile(file);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    private void sendFile(String file) {
        try {
            File f=new File(file);
            if(f.exists()){
                FileSize = f.length();
                String filelen =Long.toString(FileSize)+"\n";
                Log.d("file size sending",filelen);
                byte[] len = filelen.getBytes();
                if(s.isConnected()) {
                    Log.d("socket connected","conn");
                    DataOutputStream dd = new DataOutputStream(s.getOutputStream());
                    dd.write(len);
                    DataOutputStream dd2 = new DataOutputStream(s.getOutputStream());
                    FileInputStream fis = new FileInputStream(f);
                    BufferedInputStream bis = new BufferedInputStream(fis);
                    byte[] buffer = new byte[4096];

                    while (fis.read(buffer) > 0) {
                        dd2.write(buffer);

                    }
                    dd2.flush();
                    fis.close();
                    bis.close();
                    dd2.close();
                }




            }


        } catch (Exception e) {
            e.printStackTrace();
        }

    }
}
