package com.awais.storemanagementsystem.ui.login

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.text.TextUtils
import android.text.method.HideReturnsTransformationMethod
import android.text.method.PasswordTransformationMethod
import android.util.Log
import android.view.View
import android.widget.ImageView
import androidx.core.view.isVisible
import com.awais.storemanagementsystem.R
import com.awais.storemanagementsystem.databinding.ActivityLogInBinding
import com.awais.storemanagementsystem.model.ShopDetailResponse
import com.awais.storemanagementsystem.util.ActivityUtils
import com.awais.storemanagementsystem.util.UserData
import com.awais.storemanagementsystem.util.Utilities
import com.google.firebase.database.DataSnapshot
import com.google.firebase.database.DatabaseError
import com.google.firebase.database.FirebaseDatabase
import com.google.firebase.database.ValueEventListener
import com.google.gson.Gson

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
        binding.createNow.setOnClickListener {
          //  ActivityUtils.startRegisterActivity(this)
            ActivityUtils.startCallActivity(
                this, "+923066395565"
            )
        }

    }


    fun getUsers() {
        FirebaseDatabase.getInstance().reference.child("Shops").addValueEventListener(object :
            ValueEventListener {
            override fun onDataChange(snapshot: DataSnapshot) {
                if (snapshot.exists()) {
                    val list: ArrayList<ShopDetailResponse> = ArrayList()
                    for (d in snapshot.children) {
                        Log.e("data", d.value.toString())
                        val user = Gson().fromJson(d.value.toString(), ShopDetailResponse::class.java)
                        list.add(user)
                    }
                    val mUser = list.find {
                        it.email == binding.edittextEmail.text.toString()
                    }
                    if (mUser == null) {
                        Utilities.showToast(this@LogInActivity, "Please enter your correct user id")
                        binding.login.isVisible = true
                        binding.progressButton.isVisible = false
                        return
                    }
                    if(mUser.isAllow == false){
                        Utilities.showSnackbar(binding.root,"Not allow to use",null,R.color.Red)
                        binding.login.isVisible = true
                        binding.progressButton.isVisible = false
                        return
                    }
                    if (mUser.password != binding.edittextPassword.text.toString()) {
                        Utilities.showToast(this@LogInActivity, "Please enter correct password")
                        binding.login.isVisible = true
                        binding.progressButton.isVisible = false
                        return
                    }
                    UserData.saveUser(this@LogInActivity, mUser)
                    binding.login.isVisible = true
                    binding.progressButton.isVisible = false
                    ActivityUtils.startMainActivity(this@LogInActivity)
                    finish()
                }
            }

            override fun onCancelled(error: DatabaseError) {
                binding.login.isVisible = true
                binding.progressButton.isVisible = false
                Utilities.showSnackbar(
                    binding.root,
                    "No internet working please try again",
                    "",
                    getColor(R.color.Red)
                ) {
                }
            }
        })
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
        getUsers()

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