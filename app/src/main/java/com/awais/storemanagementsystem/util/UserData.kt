package com.awais.storemanagementsystem.util

import android.annotation.SuppressLint
import android.content.Context
import android.content.Context.MODE_PRIVATE
import android.content.SharedPreferences
import com.awais.storemanagementsystem.model.UserDataResponse
import com.google.gson.Gson
import java.text.SimpleDateFormat
import java.util.*


object UserData {

    private const val SHARE_PREFRENCE_NAME = "currantUserDate"
    private const val USER_NAME = "userName"
    private const val USER_LOGIN = "userLogIn"
    private const val USER_IMAGE = "userImage"

    const val channelID = "J2ynUem3MhIjF9La"
    const val roomName = "Quiz"
    const val roomNameNotes = "NotesBoard"

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

    fun saveUser(
        context: Context,
        user: UserDataResponse,
    ) {
        val editor = getSharedPreferencesEditor(context)
        editor.putString(USER_NAME, Gson().toJson(user))
        editor.commit()
        saveIsLogIn(context,true)
    }

    private fun saveIsLogIn(
        context: Context, login: Boolean
    ) {
        val editor = getSharedPreferencesEditor(context)
        editor.putBoolean(USER_LOGIN, login)
        editor.commit()
    }

    fun saveImage(
        context: Context, image: String
    ) {
        val editor = getSharedPreferencesEditor(context)
        editor.putString(USER_IMAGE, image)
        editor.commit()
    }

    fun getUser(context: Context): UserDataResponse {
        val editor = getSharedPreferences(context)
        val data = editor.getString(USER_NAME,"{}")
        if(data == "{}")
            return UserDataResponse()

        return  Gson().fromJson(
           data ,UserDataResponse::class.java
        )
    }

    fun userLogIn(context: Context): Boolean {
        return try {
            getSharedPreferences(context).getBoolean(USER_LOGIN, false)
        } catch (e: Exception) {
            false
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

}