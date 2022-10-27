package com.awais.storemanagementsystem.ui.login

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.text.TextUtils
import android.text.method.HideReturnsTransformationMethod
import android.text.method.PasswordTransformationMethod
import android.view.View
import android.widget.ImageView
import androidx.core.view.isVisible
import com.awais.storemanagementsystem.R
import com.awais.storemanagementsystem.databinding.ActivityLogInBinding
import com.awais.storemanagementsystem.util.ActivityUtils
import com.awais.storemanagementsystem.util.Utilities

class LogInActivity : AppCompatActivity() {

    private lateinit var binding: ActivityLogInBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityLogInBinding.inflate(layoutInflater)
        setContentView(binding.root)
        binding.login.setOnClickListener {
            registerNewUser()
        }
        binding.forgetPassword.setOnClickListener {
            ActivityUtils.startCallActivity(
                this, "+923066395565"
            )
        }

    }

    private fun registerNewUser() {
        val email: String = binding.edittextEmail.text.toString()
        val password: String = binding.edittextPassword.text.toString()
        if (TextUtils.isEmpty(email)) {
            Utilities.showToast(this, "Please enter user id")
            return
        }
        if (TextUtils.isEmpty(password)) {
            Utilities.showToast(this, "Please enter password")
            return
        }
        binding.login.isVisible = false
        binding.progressButton.isVisible = true

        ActivityUtils.startMainActivity(this)
        finish()
    }


    fun showHidePass(view: View) {

        if (view.id == R.id.show_pass_btn) {

            if (binding.edittextPassword.transformationMethod.equals(PasswordTransformationMethod.getInstance())) {
                (view as ImageView).setImageResource(R.drawable.ic_password_hide)

                //Show Password
                binding.edittextPassword.transformationMethod =
                    HideReturnsTransformationMethod.getInstance()
            } else {
                (view as ImageView).setImageResource(R.drawable.ic_password_eye)

                //Hide Password
                binding.edittextPassword.transformationMethod =
                    PasswordTransformationMethod.getInstance()

            }
        }
    }


}