package com.awais.storemanagementsystem.ui.login

import android.annotation.SuppressLint
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.text.TextUtils
import android.widget.Toast
import androidx.core.view.isVisible
import com.awais.storemanagementsystem.R
import com.awais.storemanagementsystem.databinding.ActivityRegisterBinding
import com.awais.storemanagementsystem.model.ShopDetailResponse
import com.awais.storemanagementsystem.util.UserData
import com.awais.storemanagementsystem.util.Utilities
import com.google.android.material.snackbar.Snackbar
import com.google.firebase.database.FirebaseDatabase
import com.google.gson.Gson

class RegisterActivity : AppCompatActivity() {

    private lateinit var binding: ActivityRegisterBinding
    var password: String? = null

    @SuppressLint("UseCompatLoadingForDrawables")
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        binding = ActivityRegisterBinding.inflate(layoutInflater)
        setContentView(binding.root)
        setSupportActionBar(binding.toolbar)
        supportActionBar?.setDisplayHomeAsUpEnabled(true)
        supportActionBar?.setDisplayShowHomeEnabled(true)
        binding.toolbar.navigationIcon = getDrawable(R.drawable.ic_back_arrow_white)
        binding.toolbar.setNavigationOnClickListener {
            finish()
        }
        binding.saveButton.setOnClickListener {
            validation()
        }
        if (intent.getBooleanExtra("isEdit", false)) {
            val user = UserData.getUser(this@RegisterActivity)
            binding.shopNameEditText.setText(user.shopName)
            binding.shopTypeEditText.setText(user.shopType)
            binding.employeeEditText.setText(user.employees.toString())
            binding.phoneNumberEditText.setText(user.contactNumber)
            binding.mobileNumberEditText.setText(user.mobileNumber)
            binding.targetMaxEditText.setText(user.dailyTargetMax.toString())
            binding.targetMinEditText.setText(user.dailyTargetMin.toString())
            binding.countryEditText.setText(user.country)
            binding.cityEditText.setText(user.city)
            binding.addressEditText.setText(user.address)
            binding.ownerNameEditText.setText(user.ownerName)
            binding.ownerMobileEditText.setText(user.ownerNumber)
            binding.emailAddressEditText.setText(user.email)
            password = user.password
            binding.oldPasswod.isVisible = password != null
        }

    }

    private fun validation() {
        if (TextUtils.isEmpty(binding.shopNameEditText.text)) {
            binding.shopNameEditText.error = "Enter Shop Name"
            binding.shopNameEditText.requestFocus()
            return
        }
        binding.shopNameEditText.error = null
        if (TextUtils.isEmpty(binding.shopTypeEditText.text)) {
            binding.shopNameEditText.error = "Enter Shop Type"
            binding.shopNameEditText.requestFocus()
            return
        }
        binding.shopTypeEditText.error = null
        if (TextUtils.isEmpty(binding.mobileNumberEditText.text)) {
            binding.mobileNumberEditText.error = "Enter Mobile Number"
            binding.mobileNumberEditText.requestFocus()
            return
        }
        binding.mobileNumberEditText.error = null
        if (TextUtils.isEmpty(binding.employeeEditText.text)) {
            binding.employeeEditText.error = "Enter Employee Number"
            binding.employeeEditText.requestFocus()
            return
        }
        binding.employeeEditText.error = null
        if (TextUtils.isEmpty(binding.targetMinEditText.text)) {
            binding.targetMinEditText.error = "Enter minimum daily sale target"
            binding.targetMinEditText.requestFocus()
            return
        }
        binding.targetMinEditText.error = null
        if (TextUtils.isEmpty(binding.targetMaxEditText.text)) {
            binding.targetMaxEditText.error = "Enter maximum daily sale target"
            binding.targetMaxEditText.requestFocus()
            return
        }
        binding.targetMaxEditText.error = null
        if (TextUtils.isEmpty(binding.countryEditText.text)) {
            binding.countryEditText.error = "Enter country name"
            binding.countryEditText.requestFocus()
            return
        }
        binding.countryEditText.error = null
        if (TextUtils.isEmpty(binding.cityEditText.text)) {
            binding.cityEditText.error = "Enter city name"
            binding.cityEditText.requestFocus()
            return
        }
        binding.cityEditText.error = null
        if (TextUtils.isEmpty(binding.addressEditText.text)) {
            binding.addressEditText.error = "Enter address"
            binding.addressEditText.requestFocus()
            return
        }
        binding.addressEditText.error = null
        if (TextUtils.isEmpty(binding.ownerNameEditText.text)) {
            binding.ownerNameEditText.error = "Enter owner name"
            binding.ownerNameEditText.requestFocus()
            return
        }
        binding.ownerNameEditText.error = null
        if (TextUtils.isEmpty(binding.ownerMobileEditText.text)) {
            binding.ownerMobileEditText.error = "Enter owner mobile number"
            binding.ownerMobileEditText.requestFocus()
            return
        }
        binding.ownerMobileEditText.error = null
        if (TextUtils.isEmpty(binding.employeeEditText.text)) {
            binding.employeeEditText.error = "Enter email address"
            binding.employeeEditText.requestFocus()
            return
        }
        binding.employeeEditText.error = null
        if(password != null){
            if (!TextUtils.equals(password, binding.oldPasswodEditText.text)) {
                binding.passwrod2EditText.error = "Enter correct password"
                binding.passwrod2EditText.requestFocus()
                return
            }
            binding.passwrod2EditText.error = null
        }
        if (TextUtils.isEmpty(binding.passwodEditText.text)) {
            binding.passwodEditText.error = "Enter email password"
            binding.passwodEditText.requestFocus()
            return
        }
        binding.passwodEditText.error = null
        if (TextUtils.isEmpty(binding.passwrod2EditText.text)) {
            binding.passwrod2EditText.error = "Re-Enter email password"
            binding.passwrod2EditText.requestFocus()
            return
        }
        binding.passwrod2EditText.error = null
        if (!TextUtils.equals(binding.passwodEditText.text, binding.passwrod2EditText.text)) {
            binding.passwrod2EditText.error = "Enter same password"
            binding.passwrod2EditText.requestFocus()
            return
        }
        binding.passwrod2EditText.error = null

        save()

    }

    fun save() {
        val database = FirebaseDatabase.getInstance().reference
        val user = ShopDetailResponse(
            shopName = binding.shopNameEditText.text.toString(),
            shopType = binding.shopTypeEditText.text.toString(),
            employees = try {
                binding.employeeEditText.text.toString().toInt()
            } catch (ex: Exception) {
                0
            },
            contactNumber = binding.phoneNumberEditText.text.toString(),
            mobileNumber = binding.mobileNumberEditText.text.toString(),
            country = binding.countryEditText.text.toString(),
            city = binding.cityEditText.text.toString(),
            dailyTargetMax = try {
                binding.targetMaxEditText.text.toString().toDouble()
            } catch (ex: Exception) {
                0.0
            },
            dailyTargetMin = try {
                binding.targetMinEditText.text.toString().toDouble()
            } catch (ex: Exception) {
                0.0
            },
            address = binding.addressEditText.text.toString(),
            email = binding.emailAddressEditText.text.toString(),
            ownerName = binding.ownerNameEditText.text.toString(),
            ownerNumber = binding.ownerMobileEditText.text.toString(),
            password = binding.passwodEditText.text.toString(),
            deviceName = Utilities.deviceName
        )
        val gson = Gson().toJson(user)
        database.child("Shops").child(user.email.toString()).setValue(gson)
            .addOnCompleteListener {
                val msg =
                    "Dear ${user.ownerName} Wel Come.\n" +
                            "Congratulation you are added in our S,M,S family.\n"
                val msg2 = "Login\n" +
                        "User ID: ${user.email}\n" +
                        "Password: ${user.password}\n" +
                        "Shop Name : ${user.shopName}\n"
                val msg3 =
                    "For More Detail contact on +923066395565 .\nThanks you.."
                Utilities.sendMessageOnNumber(
                    this, user.ownerNumber ?: user.contactNumber ?: user.mobileNumber ?: "1234", msg
                )
                Utilities.sendMessageOnNumber(
                    this,
                    user.ownerNumber ?: user.contactNumber ?: user.mobileNumber ?: "1234",
                    msg2
                )
                Utilities.sendMessageOnNumber(
                    this,
                    user.ownerNumber ?: user.contactNumber ?: user.mobileNumber ?: "1234",
                    msg3
                )
                binding.saveButton.isVisible = true
                binding.progressButton.isVisible = false
                Toast.makeText(applicationContext, "Shop Added Successfully", Toast.LENGTH_LONG)
                    .show()
                finish()
            }.addOnCanceledListener {
                binding.saveButton.isVisible = true
                binding.progressButton.isVisible = false
                Snackbar.make(binding.root, "Shop Not Added Successfully", Snackbar.LENGTH_LONG)
                    .setAction("Try Again") {
                        save()
                    }.show()
            }
    }


}