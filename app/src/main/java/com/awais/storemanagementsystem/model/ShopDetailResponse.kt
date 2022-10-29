package com.awais.storemanagementsystem.model

import android.os.Parcelable
import com.google.gson.annotations.SerializedName
import kotlinx.parcelize.Parcelize

@Parcelize
data class ShopDetailResponse(

    @field:SerializedName("country")
    val country: String? = null,

    @field:SerializedName("image")
    val image: String? = null,

    @field:SerializedName("address")
    val address: String? = null,

    @field:SerializedName("owner_name")
    val ownerName: String? = null,

    @field:SerializedName("lng")
    val lng: Double? = null,

    @field:SerializedName("city")
    val city: String? = null,

    @field:SerializedName("owner_number")
    val ownerNumber: String? = null,

    @field:SerializedName("daily_target_max")
    val dailyTargetMax: Double? = null,

    @field:SerializedName("shop_name")
    val shopName: String? = null,

    @field:SerializedName("contact_number")
    val contactNumber: String? = null,

    @field:SerializedName("password")
    val password: String? = null,

    @field:SerializedName("shop_type")
    val shopType: String? = null,

    @field:SerializedName("mobile_number")
    val mobileNumber: String? = null,

    @field:SerializedName("employees")
    val employees: Int? = null,

    @field:SerializedName("daily_target_min")
    val dailyTargetMin: Double? = null,

    @field:SerializedName("lat")
    val lat: Double? = null,

    @field:SerializedName("email")
    val email: String? = null,

    @field:SerializedName("deviceID")
    val deviceID: String? = null,

    @field:SerializedName("deviceName")
    val deviceName: String? = null

) : Parcelable
