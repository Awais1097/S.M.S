package com.awais.storemanagementsystem.util

import android.annotation.SuppressLint
import android.content.Context
import android.content.Context.MODE_PRIVATE
import android.content.SharedPreferences
import android.util.Log
import com.awais.storemanagementsystem.database.DataBaseConnection.Companion.DATABASE_NAME
import com.awais.storemanagementsystem.database.DataBaseConnection.Companion.IP_ADDRESS
import com.awais.storemanagementsystem.database.DataBaseConnection.Companion.ORACLE
import com.awais.storemanagementsystem.database.DataBaseConnection.Companion.PASSWORD
import com.awais.storemanagementsystem.database.DataBaseConnection.Companion.USER
import com.awais.storemanagementsystem.database.ServerData
import com.awais.storemanagementsystem.model.ShopDetailResponse
import com.google.gson.Gson
import java.text.SimpleDateFormat
import java.util.*


object UserData {

    private const val SHARE_PREFRENCE_NAME = "currantUserDate"
    private const val USER_NAME = "userName"
    private const val USER_LOGIN = "userLogIn"
    private const val USER_ON_OFF = "shopOnOff"
    private const val USER_IMAGE = "userImage"
    private const val SERVER_IP = "serverIP"
    private const val SERVER_DATABASE = "serverDatabase"
    private const val SERVER_USER = "serverUser"
    private const val SERVER_PASSWORD = "serverPassword"
    private const val SERVER_TYPE = "serverType"

    @SuppressLint("ConstantLocale")
    val simpleDateFormat = SimpleDateFormat("yyyy/MM/dd HH:mm:ss", Locale.getDefault())

    @SuppressLint("ConstantLocale")
    val simpleTimeFormat = SimpleDateFormat("HH:mm aa", Locale.getDefault())

    @SuppressLint("ConstantLocale")
    val newDateFormat = SimpleDateFormat("yyyyMMddHHmmss", Locale.getDefault())

    @SuppressLint("ConstantLocale")
    val simpleDateFormat2 = SimpleDateFormat("yyyy-MM-dd", Locale.getDefault())

    @SuppressLint("ConstantLocale")
    val simpleDateFormat3 = SimpleDateFormat("yyyy/MM/dd", Locale.getDefault())

    @SuppressLint("ConstantLocale")
    val simpleDateFormat4 = SimpleDateFormat("EEEE", Locale.getDefault())

    @SuppressLint("ConstantLocale")
    val simpleDateFormat5 = SimpleDateFormat("MMMM dd, yyyy", Locale.getDefault())

    @SuppressLint("ConstantLocale")
    val simpleDateFormat6 = SimpleDateFormat("MMM dd, yyyy", Locale.getDefault())

    @SuppressLint("ConstantLocale")
    val simpleDateFormat7 = SimpleDateFormat("MMM dd, yyyy", Locale.getDefault())

    @SuppressLint("ConstantLocale")
    val simpleDateFormat8 = SimpleDateFormat("MMMM yyyy", Locale.getDefault())

    @SuppressLint("ConstantLocale")
    val simpleDateFormat9 = SimpleDateFormat("EEEE dd MMMM yyyy", Locale.getDefault())

    fun saveUser(context: Context, user: ShopDetailResponse) {
        val editor = getSharedPreferencesEditor(context)
        editor.putString(USER_NAME, Gson().toJson(user))
        editor.commit()
        saveIsLogIn(context, true)
    }

    fun saveIsLogIn(context: Context, login: Boolean) {
        val editor = getSharedPreferencesEditor(context)
        editor.putBoolean(USER_LOGIN, login)
        editor.commit()
    }

    fun saveShopOnOff(context: Context, login: Boolean) {
        val editor = getSharedPreferencesEditor(context)
        editor.putBoolean(USER_ON_OFF, login)
        editor.commit()
        Log.e("Shop", "$login")
    }

    fun saveImage(context: Context, image: String) {
        val editor = getSharedPreferencesEditor(context)
        editor.putString(USER_IMAGE, image)
        editor.commit()
    }

    fun getUser(context: Context): ShopDetailResponse {
        val editor = getSharedPreferences(context)
        val data = editor.getString(USER_NAME, "{}")
        if (data == "{}") return ShopDetailResponse()
        return Gson().fromJson(data, ShopDetailResponse::class.java)
    }

    fun userLogIn(context: Context): Boolean {
        return try {
            getSharedPreferences(context).getBoolean(USER_LOGIN, false)
        } catch (e: Exception) {
            false
        }
    }

    fun userShopOnOff(context: Context): Boolean {
        return try {
            getSharedPreferences(context).getBoolean(USER_ON_OFF, true)
        } catch (e: Exception) {
            true
        }
    }

    fun getImageUrl(context: Context): String {
        return getSharedPreferences(context).getString(USER_IMAGE, "") ?: ""
    }

    fun clearAll(context: Context) {
        getSharedPreferencesEditor(context).clear()
    }

    fun getSharedPreferences(context: Context): SharedPreferences {
        return context.getSharedPreferences(SHARE_PREFRENCE_NAME, MODE_PRIVATE)
    }

    private fun getSharedPreferencesEditor(context: Context): SharedPreferences.Editor {
        return getSharedPreferences(context).edit()
    }

    fun saveIP(context: Context, ip: ServerData) {
        val editor = getSharedPreferencesEditor(context)
        editor.putString(SERVER_IP, ip.ip)
        editor.putString(SERVER_DATABASE, ip.database)
        editor.putString(SERVER_USER, ip.user)
        editor.putString(SERVER_PASSWORD, ip.password)
        editor.putString(SERVER_TYPE, ip.type)
        editor.commit()
    }

    fun getIP(context: Context): ServerData {
        val editor = getSharedPreferences(context)
        return ServerData(
            editor.getString(SERVER_IP, IP_ADDRESS)
                ?:IP_ADDRESS,
            editor.getString(SERVER_DATABASE, DATABASE_NAME)
                ?: DATABASE_NAME,
            editor.getString(SERVER_USER, USER)
                ?: USER,
            editor.getString(SERVER_PASSWORD, PASSWORD)
                ?: PASSWORD,
            editor.getString(SERVER_TYPE, ORACLE)
                ?: ORACLE
        )
    }

}