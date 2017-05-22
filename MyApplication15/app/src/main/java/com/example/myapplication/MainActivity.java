package com.example.myapplication;

import android.media.Image;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;

import com.bumptech.glide.Glide;
import com.bumptech.glide.request.target.GlideDrawableImageViewTarget;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {
    private final static char[] ChoSung = { 0x3131, 0x3132, 0x3134, 0x3137, 0x3138, 0x3139, 0x3141, 0x3142, 0x3143, 0x3145, 0x3146, 0x3147, 0x3148, 0x3149, 0x314a, 0x314b, 0x314c, 0x314d, 0x314e };
    private final static char[] JungSung = { 0x314f, 0x3150, 0x3151, 0x3152, 0x3153, 0x3154, 0x3155, 0x3156, 0x3157, 0x3158, 0x3159, 0x315a, 0x315b, 0x315c, 0x315d, 0x315e, 0x315f, 0x3160, 0x3161, 0x3162, 0x3163 };
    ImageView gif1,gif2;
    EditText editText;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        editText =(EditText)findViewById(R.id.editText);
        Button button =(Button)findViewById(R.id.button);
        button.setOnClickListener(this);
        gif1=(ImageView)findViewById(R.id.gif1);
        gif2=(ImageView)findViewById(R.id.gif2);
    }


    public static String hangulToJaso(String $str)
    {
        // 유니코드 한글 문자열을 입력 받음
        int a, b, c; // 자소 버퍼: 초성/중성/종성 순
        String result = "";

        for (int i = 0; i < $str.length(); i++)
        {
            char ch = $str.charAt(i);

            if (ch >= 0xAC00 && ch <= 0xD7A3)
            { // "AC00:가" ~ "D7A3:힣" 에 속한 글자면 분해
                c = ch - 0xAC00;
                a = c / (21 * 28);
                c = c % (21 * 28);
                b = c / 28;
                c = c % 28;
                Log.d("chosung",a+"");
                Log.d("jungsung",b+"");
                result = result + a +"/"+ b;
                if (c != 0);
                //result = result + JongSung[c]; // c가 0이 아니면, 즉 받침이 있으면
            }
            else
            {
                result = result + ch;
            }
        }
        return result;
    }
    @Override
    public void onClick(View v) {
        String result =editText.getText().toString();
        String jaso = hangulToJaso(result);
        String[] han =jaso.split("/");
        GlideDrawableImageViewTarget ivt = new GlideDrawableImageViewTarget(gif1);
        GlideDrawableImageViewTarget ivt2 = new GlideDrawableImageViewTarget(gif2);
        switch (Integer.parseInt(han[0])){
            case 0:
                Glide.with(this).load(R.raw.r).into(ivt);
                break;
            case 2:
                Glide.with(this).load(R.raw.s).into(ivt);
                break;
            case 3:
                Glide.with(this).load(R.raw.e).into(ivt);
                break;
            case 5:
                Glide.with(this).load(R.raw.f).into(ivt);
                break;
            case 6:
                Glide.with(this).load(R.raw.a).into(ivt);
                break;
            case 7:
                Glide.with(this).load(R.raw.q).into(ivt);
                break;
            case 8:
                Glide.with(this).load(R.raw.t).into(ivt);
                break;
        }
        switch (Integer.parseInt(han[1])){
            case 0:
                Glide.with(this).load(R.raw.k).into(ivt2);
                break;
            case 4:
                Glide.with(this).load(R.raw.j).into(ivt2);
                break;
            case 8:
                Glide.with(this).load(R.raw.h).into(ivt2);
                break;
            case 13:
                Glide.with(this).load(R.raw.n).into(ivt2);
                break;
            case 18:
                Glide.with(this).load(R.raw.m).into(ivt2);
                break;
        }
    }
}
