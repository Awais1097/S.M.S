package com.awais.storemanagementsystem.model

import android.os.Parcelable
import com.google.gson.annotations.SerializedName
import kotlinx.parcelize.Parcelize

@Parcelize
data class UserDataResponse(

    @field:SerializedName("country")
    val country: String? = "",

    @field:SerializedName("userid")
    val userid: String? = "",

    @field:SerializedName("type")
    val userType: String? = "",

    @field:SerializedName("gander")
    val gander: String? = "",

    @field:SerializedName("address")
    val address: String? = "",

    @field:SerializedName("phone")
    val phone: String? = "",

    @field:SerializedName("emergencyNo")
    val emergencyNo: String? = "",

    @field:SerializedName("imageBitmap")
    val imageBitmap: String? = "",

    @field:SerializedName("city")
    val city: String? = "",

    @field:SerializedName("Skills")
    val skills: String? = "",

    @field:SerializedName("subjects")
    val subjects: List<String?>? = ArrayList(),

    @field:SerializedName("name")
    val name: String? = "",

    @field:SerializedName("mobile")
    val mobile: String? = "",

    @field:SerializedName("email")
    val email: String? = "",

    @field:SerializedName("password")
    var password: String? = "",

    @field:SerializedName("inTime")
    val inTime: String? = "",

    @field:SerializedName("outTime")
    val outTime: String? = "",

    @field:SerializedName("objective")
    val objective: String? = "",

    @field:SerializedName("degreeInstitution")
    val degreeInstitution: String? = "",

    @field:SerializedName("year")
    val year: String? = "",

    @field:SerializedName("degree")
    val degree: String? = "",

    @field:SerializedName("duration")
    val duration: String? = "",

    @field:SerializedName("jobTitle")
    val jobTitle: String? = "",

    @field:SerializedName("jobDetail")
    val jobDetail: String? = "",

    @field:SerializedName("inchageOf")
    val inchageOf: String? = ""

) : Parcelable {

}