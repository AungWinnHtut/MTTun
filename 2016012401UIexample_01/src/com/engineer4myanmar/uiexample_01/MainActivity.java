package com.engineer4myanmar.uiexample_01;

import android.app.Activity;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class MainActivity extends Activity implements OnClickListener {
	EditText etUname,etPass;
	Button btnLogin,btnCancel;
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        etUname = (EditText)findViewById(R.id.etUname);
        etPass = (EditText)findViewById(R.id.etPass);
        btnCancel = (Button)findViewById(R.id.btnCancel);
        btnLogin = (Button)findViewById(R.id.btnLogin);
        btnLogin.setOnClickListener(this);
        btnCancel.setOnClickListener(this);
    }
 
    protected void onStart() {   
    	super.onStart();
    	Toast.makeText(getApplicationContext(), "onStart", Toast.LENGTH_SHORT).show();
    }
    
    protected void onResume() {
    	super.onResume();
    	Toast.makeText(getApplicationContext(), "onResume", Toast.LENGTH_SHORT).show();
    }
    
    protected void onPause() {
    	super.onPause();
    	Toast.makeText(getApplicationContext(), "onPause", Toast.LENGTH_SHORT).show();
    }
    
    protected void onStop() {
    	super.onStop();
    	Toast.makeText(getApplicationContext(), "onStop", Toast.LENGTH_SHORT).show();
    }
    
    protected void onDestroy() {
    	super.onDestroy();
    	Toast.makeText(getApplicationContext(), "onDestory", Toast.LENGTH_SHORT).show();
    }
    
    protected void onSaveInstanceState(Bundle outState) {
    	super.onSaveInstanceState(outState);
    	Toast.makeText(getApplicationContext(), "onSaveInstanceState", Toast.LENGTH_SHORT).show();
    }
    
    protected void onRestart() {
    	super.onRestart();
    	Toast.makeText(getApplicationContext(), "onRestart", Toast.LENGTH_SHORT).show();
    }
    
    protected void onRestoreInstanceState(Bundle savedInstanceState) {
    	super.onRestoreInstanceState(savedInstanceState);
    	Toast.makeText(getApplicationContext(), "onRestoreInstanceState", Toast.LENGTH_SHORT).show();
    }

	public void onClick(View v) {
		
		String strUname = etUname.getText().toString();
		String strPass = etPass.getText().toString();
		
		switch(v.getId())
		{
		case R.id.btnLogin: 
			if(strPass.equalsIgnoreCase("awh"))
			{
				
			}
			break;
		case R.id.btnCancel:
			etUname.setText("");
			etPass.setText("");
			etUname.requestFocus();
			break;
		}
		
	}
    
    

}
