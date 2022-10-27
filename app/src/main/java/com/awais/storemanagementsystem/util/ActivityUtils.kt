package com.awais.storemanagementsystem.util

import android.annotation.SuppressLint
import android.content.Context
import android.content.Intent
import android.database.Cursor
import android.net.Uri
import android.provider.ContactsContract
import android.widget.Toast
import com.awais.storemanagementsystem.MainActivity
import com.awais.storemanagementsystem.ui.FrameActivity
import com.awais.storemanagementsystem.ui.login.LogInActivity


object ActivityUtils {

    fun startActivity(context: Context, intent: Intent) {
        context.startActivity(intent)
        /* (context as Activity).overridePendingTransition(
             androidx.appcompat.R.anim.abc_slide_in_bottom,
             androidx.appcompat.R.anim.abc_slide_out_bottom
         )*/
    }

    fun startCallActivity(context: Context, number: String) {
        if (number != "1234") {
            val intent = Intent(Intent.ACTION_CALL, Uri.parse("tel:${number}"))
            startActivity(context, intent)
        } else {
            Toast.makeText(context, "No Number added", Toast.LENGTH_SHORT).show()
        }
    }

    fun startWhatsAppActivity(context: Context, number: String) {
        try {
            if (number != "1234") {
                val uri = Uri.parse("smsto:$number")
                val i = Intent(Intent.ACTION_SENDTO, uri)
                i.setPackage("com.whatsapp")
                startActivity(context, i)
            } else {
                Toast.makeText(context, "No Number added", Toast.LENGTH_SHORT).show()
            }
        } catch (ex: Exception) {
            try {
                if (number != "1234") {
                    val uri = Uri.parse("smsto:$number")
                    val i = Intent(Intent.ACTION_SENDTO, uri)
                    i.setPackage("com.whatsapp.w4b")
                    startActivity(context, i)
                } else {
                    Toast.makeText(context, "No Number added", Toast.LENGTH_SHORT).show()
                }
            } catch (ex: Exception) {
                //   Toast.makeText(context, "Please install WhatsApp", Toast.LENGTH_SHORT).show()
                try {
                    if (number != "1234") {
                        val uri = Uri.parse("smsto:$number")
                        val i = Intent(Intent.ACTION_SENDTO, uri)
                        i.setPackage("com.gbwhatsapp")
                        startActivity(context, i)
                    } else {
                        Toast.makeText(context, "No Number added", Toast.LENGTH_SHORT).show()
                    }
                } catch (ex: Exception) {
                    Toast.makeText(context, "Please install WhatsApp", Toast.LENGTH_SHORT).show()
                }
            }
            //Toast.makeText(context, "Please install WhatsApp", Toast.LENGTH_SHORT).show()
        }
    }

    fun startWhatsAppCallActivity(context: Context, number: String) {
        try {
            if (number != "1234") {
                val intent = Intent()
                intent.action = Intent.ACTION_VIEW
                val name = getContactName(number, context)
                if (name != null) {
                    var whatsappcall = getContactIdForWhatsAppCall(name, context)
                    if (whatsappcall != 0) {
                        intent.setDataAndType(
                            Uri.parse("content://com.android.contacts/data/$whatsappcall"),
                            "vnd.android.cursor.item/vnd.com.whatsapp.voip.call"
                        )
                        intent.setPackage("com.whatsapp")
                        startActivity(context, intent)
                    } else {
                        whatsappcall = getContactIdForWhatsAppBCall(name, context)
                        if (whatsappcall != 0) {
                            intent.setDataAndType(
                                Uri.parse("content://com.android.contacts/data/$whatsappcall"),
                                "vnd.android.cursor.item/vnd.com.whatsapp.w4b.voip.call"
                            )
                            intent.setPackage("com.whatsapp.w4b")
                            startActivity(context, intent)
                        }
                    }
                }
            } else {
                Toast.makeText(context, "No Number added", Toast.LENGTH_SHORT).show()
            }
        } catch (ex: Exception) {
            Toast.makeText(context, "Please install WhatsApp", Toast.LENGTH_SHORT).show()
        }
    }

    fun startFrameActivity(context: Context?, title: String?, fragment: String?) {
        context?.startActivity(
            Intent(context, FrameActivity::class.java).putExtra(FrameActivity.KEY_TITLE, title)
                .putExtra(FrameActivity.KEY_FRAGMENT, fragment)
        )
    }

    fun getContactName(phoneNumber: String?, context: Context): String? {
        try {
            val uri = Uri.withAppendedPath(
                ContactsContract.PhoneLookup.CONTENT_FILTER_URI,
                Uri.encode(phoneNumber)
            )
            val projection = arrayOf(ContactsContract.PhoneLookup.DISPLAY_NAME)
            var contactName = ""
            val cursor: Cursor? = context.contentResolver.query(uri, projection, null, null, null)
            if (cursor != null) {
                if (cursor.moveToFirst()) {
                    contactName = cursor.getString(0)
                }
                cursor.close()
            }
            return contactName
        } catch (ex: Exception) {
            return null
        }
    }


    @SuppressLint("Range")
    fun getContactIdForWhatsAppCall(name: String, context: Context): Int {
        val cursor = context.contentResolver.query(
            ContactsContract.Data.CONTENT_URI,
            arrayOf(ContactsContract.Data._ID),
            ContactsContract.Data.DISPLAY_NAME + "=? and " + ContactsContract.Data.MIMETYPE + "=?",
            arrayOf(name, "vnd.android.cursor.item/vnd.com.whatsapp.voip.call"),
            ContactsContract.Contacts.DISPLAY_NAME
        )
        return if (cursor?.count ?: 0 > 0) {
            cursor?.moveToNext()
            val phoneContactID: Int =
                cursor!!.getInt(cursor.getColumnIndex(ContactsContract.Data._ID))
            println("9999999999999999          name  $name      id    $phoneContactID")
            phoneContactID
        } else {
            0
        }
    }

    @SuppressLint("Range")
    fun getContactIdForWhatsAppBCall(name: String, context: Context): Int {
        val cursor = context.contentResolver.query(
            ContactsContract.Data.CONTENT_URI,
            arrayOf(ContactsContract.Data._ID),
            ContactsContract.Data.DISPLAY_NAME + "=? and " + ContactsContract.Data.MIMETYPE + "=?",
            arrayOf(name, "vnd.android.cursor.item/vnd.com.whatsapp.w4b.voip.call"),
            ContactsContract.Contacts.DISPLAY_NAME
        )
        return if (cursor?.count ?: 0 > 0) {
            cursor?.moveToNext()
            val phoneContactID: Int =
                cursor!!.getInt(cursor.getColumnIndex(ContactsContract.Data._ID))
            println("9999999999999999          name  $name      id    $phoneContactID")
            phoneContactID
        } else {
            println("8888888888888888888          ")
            0
        }
    }

    fun startMainActivity(activity: Context) {
        val intent = Intent(activity, MainActivity::class.java)
        startActivity(activity, intent)
    }

    fun startLoginActivity(activity: Context) {
        val intent = Intent(activity, LogInActivity::class.java)
        startActivity(activity, intent)
    }


}