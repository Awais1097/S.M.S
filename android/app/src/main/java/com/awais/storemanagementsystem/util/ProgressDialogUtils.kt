package com.awais.storemanagementsystem.util

import android.annotation.SuppressLint
import android.content.Context
import cn.pedant.SweetAlert.SweetAlertDialog
import com.awais.storemanagementsystem.R

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




}