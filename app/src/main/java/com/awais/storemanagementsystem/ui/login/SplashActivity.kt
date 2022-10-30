package com.awais.storemanagementsystem.ui.login

import android.Manifest
import android.annotation.SuppressLint
import android.content.pm.PackageManager
import android.os.Build
import android.os.Bundle
import android.os.Handler
import android.os.Looper
import androidx.appcompat.app.AppCompatActivity
import androidx.core.app.ActivityCompat
import androidx.core.content.ContextCompat
import com.awais.storemanagementsystem.R
import com.awais.storemanagementsystem.databinding.ActivitySplashBinding
import com.awais.storemanagementsystem.util.ActivityUtils
import com.awais.storemanagementsystem.util.UserData


@SuppressLint("CustomSplashScreen")
class SplashActivity : AppCompatActivity() {
    private lateinit var binding: ActivitySplashBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivitySplashBinding.inflate(layoutInflater)
        setContentView(binding.root)
        window.navigationBarColor = ContextCompat.getColor(this, R.color.white)
        proceed()
    }

    private fun proceed() {
        val secondsDelayed = 6
        Handler(Looper.getMainLooper()).postDelayed({
            if (Build.VERSION.SDK_INT.compareTo(Build.VERSION_CODES.M) > -1) {
                if (checkAndRequestPermissions()) {
                    moveNow()
                }
                return@postDelayed
            }
            moveNow()
        }, (secondsDelayed * 100).toLong())
    }

    private fun moveNow() {
        start()
    }

    private fun start() {
        if (!UserData.userLogIn(this)) {
            ActivityUtils.startMainActivity(this)
        } else {
            ActivityUtils.startLoginActivity(this)
        }
        finish()
    }

    private fun checkAndRequestPermissions(): Boolean {
        val listPermissionsNeeded: MutableList<String> = ArrayList()
        if (
            ContextCompat.checkSelfPermission(this, Manifest.permission.CALL_PHONE) != PackageManager.PERMISSION_GRANTED||
            ContextCompat.checkSelfPermission(this, Manifest.permission.SEND_SMS) != PackageManager.PERMISSION_GRANTED||
            ContextCompat.checkSelfPermission(this, Manifest.permission.READ_CONTACTS) != PackageManager.PERMISSION_GRANTED||
            ContextCompat.checkSelfPermission(this, Manifest.permission.WRITE_EXTERNAL_STORAGE) != PackageManager.PERMISSION_GRANTED
        ) {
            listPermissionsNeeded.add(Manifest.permission.CALL_PHONE)
            listPermissionsNeeded.add(Manifest.permission.WRITE_EXTERNAL_STORAGE)
            listPermissionsNeeded.add(Manifest.permission.READ_CONTACTS)
            listPermissionsNeeded.add(Manifest.permission.SEND_SMS)
        }
        if (listPermissionsNeeded.isNotEmpty()) {
            ActivityCompat.requestPermissions(
                this,
                listPermissionsNeeded.toTypedArray(),
                1234
            )
            return false
        }
        return true
    }

    override fun onRequestPermissionsResult(
        requestCode: Int,
        permissions: Array<out String>,
        grantResults: IntArray
    ) {
        super.onRequestPermissionsResult(requestCode, permissions, grantResults)
        proceed()
    }
}