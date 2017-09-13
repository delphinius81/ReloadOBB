package com.delphinius81.reloadobb;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;

/**
 * Created by dcher on 6/1/2017.
 */

public class ReloadObbActivity extends Activity {
    private Intent myIntent;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        myIntent= new Intent(this,ReloadObbActivity.class);
        Log.i("Unity", "Exiting reload activity.");
        finish();
    }

    public void Launch(Activity activity) {
        Intent myIntent = new Intent(activity, ReloadObbActivity.class);
        startActivity(myIntent);
    }
}
