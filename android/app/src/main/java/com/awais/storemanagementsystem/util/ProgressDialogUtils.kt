package com.awais.storemanagementsystem.util

import android.annotation.SuppressLint
import android.content.Context
import android.text.InputType
import android.text.method.PasswordTransformationMethod
import android.view.ViewGroup
import android.widget.EditText
import android.widget.LinearLayout
import android.widget.RadioButton
import android.widget.RadioGroup
import cn.pedant.SweetAlert.SweetAlertDialog
import com.awais.storemanagementsystem.R
import com.awais.storemanagementsystem.database.DataBaseConnection.Companion.ORACLE
import com.awais.storemanagementsystem.database.DataBaseConnection.Companion.SQL
import com.awais.storemanagementsystem.database.ServerData

object ProgressDialogUtils {


    @SuppressLint("NewApi")
    fun createProgressDialog(
        context: Context,
        msg: String? = null,
        cancalable: Boolean? = false
    ): SweetAlertDialog {
        // context.theme.applyStyle(R.style.myAlertDialogTheme, true)
        val mProgressDialog = SweetAlertDialog(context, SweetAlertDialog.PROGRESS_TYPE)
        mProgressDialog.setCanceledOnTouchOutside(false)
        mProgressDialog.setCancelable(cancalable == true)
        mProgressDialog.titleText = msg ?: context.getString(R.string.loading)
        mProgressDialog.progressHelper.circleRadius = 80
        mProgressDialog.progressHelper.barColor = context.getColor(R.color.purple_700)
        return mProgressDialog
    }

    @SuppressLint("NewApi")
    fun showProgress(
        dialog: SweetAlertDialog,
        title: String? = null,
        message: String? = null
    ): SweetAlertDialog {
        dialog.titleText = title ?: dialog.context.getString(R.string.loading)
        dialog.contentText = message
        dialog.confirmText = dialog.context.getString(R.string.ok)
        dialog.changeAlertType(SweetAlertDialog.PROGRESS_TYPE)
        dialog.progressHelper.circleRadius = 80
        dialog.progressHelper.barColor = App.context.getColor(R.color.purple_700)
        return dialog
    }

    fun showError(
        dialog: SweetAlertDialog,
        title: String?,
        message: String?,
        okListener: SweetAlertDialog.OnSweetClickListener? = null
    ) {
        dialog.setCancelable(false)
        dialog.titleText = title
        dialog.contentText = message
        dialog.confirmText = "Update"
        dialog.cancelText = "Cancel"
        dialog.setConfirmClickListener {
            it.dismissWithAnimation()
        }
        dialog.setCancelClickListener(okListener)
        dialog.changeAlertType(SweetAlertDialog.ERROR_TYPE)
    }

    fun showSuccess(
        dialog: SweetAlertDialog,
        title: String?,
        message: String?,
        okListener: SweetAlertDialog.OnSweetClickListener? = null
    ) {
        dialog.setCancelable(false)
        dialog.titleText = title
        dialog.contentText = message
        dialog.confirmText = dialog.context.getString(R.string.ok)
        dialog.setConfirmClickListener(okListener)
        dialog.changeAlertType(SweetAlertDialog.SUCCESS_TYPE)
    }


    fun showSuccessAttendence(
        dialog: SweetAlertDialog,
        title: String?,
        message: String?,
        okListener: SweetAlertDialog.OnSweetClickListener? = null,
        canListener: SweetAlertDialog.OnSweetClickListener? = null
    ) {
        dialog.setCancelable(false)
        dialog.titleText = title
        dialog.contentText = message
        dialog.confirmText = "SEND SMS"
        dialog.setConfirmClickListener(okListener)
        dialog.cancelText = "OK"
        dialog.setCancelClickListener(canListener)
        dialog.changeAlertType(SweetAlertDialog.SUCCESS_TYPE)
    }

    interface DialogSubmitClick {
        fun onClick(ip: ServerData)
    }

    fun dialodForIPAddress(context: Context, onSubmit: DialogSubmitClick) {
        val data = UserData.getIP(context)
        val layoutView = LinearLayout(context)
        layoutView.orientation = LinearLayout.VERTICAL
        val editTextIp = EditText(context)
        editTextIp.hint = "IP Address"
        editTextIp.setText(data.ip)
        val editTextDatabase = EditText(context)
        editTextDatabase.hint = "Database Name"
        editTextDatabase.setText(data.database)
        val editTextUser = EditText(context)
        editTextUser.hint = "Database User"
        editTextUser.setText(data.user)
        val editTextPassword = EditText(context)
        editTextPassword.hint = "User Password"
        editTextPassword.setText(data.password)
        editTextPassword.inputType = InputType.TYPE_TEXT_VARIATION_PASSWORD
        editTextPassword.transformationMethod = PasswordTransformationMethod.getInstance()
        val radioButton1 = RadioButton(context)
        radioButton1.layoutParams = LinearLayout.LayoutParams(
            ViewGroup.LayoutParams.WRAP_CONTENT,
            ViewGroup.LayoutParams.WRAP_CONTENT
        )
        radioButton1.text = ORACLE
        radioButton1.id = R.id.radioButton_ID_1
        radioButton1.isChecked = data.type == ORACLE

        val radioButton2 = RadioButton(context)
        radioButton2.layoutParams = LinearLayout.LayoutParams(
            ViewGroup.LayoutParams.WRAP_CONTENT,
            ViewGroup.LayoutParams.WRAP_CONTENT
        )
        radioButton2.text = SQL
        radioButton2.id = R.id.radioButton_ID_2
        radioButton2.isChecked = data.type == SQL

        val radioGroup = RadioGroup(context)
        val params = LinearLayout.LayoutParams(
            ViewGroup.LayoutParams.MATCH_PARENT,
            ViewGroup.LayoutParams.WRAP_CONTENT
        )
        params.setMargins(0, 5, 10, 10)
        radioGroup.layoutParams = params
        radioGroup.orientation = LinearLayout.HORIZONTAL
        radioGroup.addView(radioButton1)
        radioGroup.addView(radioButton2)

        layoutView.addView(radioGroup)
        layoutView.addView(editTextIp)
        layoutView.addView(editTextDatabase)
        layoutView.addView(editTextUser)
        layoutView.addView(editTextPassword)

        val mProgressDialog = SweetAlertDialog(context, SweetAlertDialog.NORMAL_TYPE)
        mProgressDialog.setCustomView(layoutView)
        mProgressDialog.setCanceledOnTouchOutside(false)
        mProgressDialog.setCancelable(false)
        mProgressDialog.titleText = " Server Setting"
        mProgressDialog.setConfirmButton("Submit") {
            mProgressDialog.dismissWithAnimation()
            onSubmit.onClick(
                ServerData(
                    editTextIp.text.toString(),
                    editTextDatabase.text.toString(),
                    editTextUser.text.toString(),
                    editTextPassword.text.toString(),
                    if (radioGroup.checkedRadioButtonId == R.id.radioButton_ID_2) SQL else  ORACLE
                )
            )
        }
        mProgressDialog.show()

    }




}