package com.awais.storemanagementsystem.util

import android.app.Application
import android.app.NotificationChannel
import android.app.NotificationManager
import android.content.Context
import android.net.http.HttpResponseCache
import android.os.Build
import android.util.Log
import java.io.File
import java.io.IOException


class App : Application() {

    override fun onCreate() {
        super.onCreate()
        myApp = this

        try {
            val httpCacheDir = File(cacheDir, "eTBC")
            val httpCacheSize = 10 * 1024 * 1024.toLong() // 10 MiB
            HttpResponseCache.install(httpCacheDir, httpCacheSize)
            createNotificationChannel()
        } catch (e: IOException) {
            Log.i(TAG, "HTTP response cache installation failed:$e")
        }
    }

    companion object {
        private val TAG = App::class.java.simpleName
        private var myApp: Application? = null
        val context: Context get() = myApp!!.applicationContext
        val CHANNEL_ID = "awaisRouteService"
    }

    private fun createNotificationChannel() {
        /*if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.O) {
            val serviceChannel = NotificationChannel(
                CHANNEL_ID,
                YourServiceName::class.java.name,
                NotificationManager.IMPORTANCE_DEFAULT
            )
            val notificationManager = getSystemService(
                NotificationManager::class.java
            )
            notificationManager.createNotificationChannel(serviceChannel)
        }*/
    }
}