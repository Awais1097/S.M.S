package com.awais.storemanagementsystem.roomdb.entity

import androidx.room.ColumnInfo
import androidx.room.Entity
import androidx.room.PrimaryKey
import com.awais.storemanagementsystem.roomdb.entity.CompanyEntity.Companion.TABLE_COMPANY

@Entity(tableName = TABLE_COMPANY)
class CompanyEntity(
    @PrimaryKey(autoGenerate = true) var _id: Int? = null,
    @ColumnInfo(name = COL_BRANDNAME) var col_name: String? = null,
    @ColumnInfo(name = COL_ID) var col_id: String? = null,
    @ColumnInfo(name = COL_IMAGE) var col_imge: String? = null,
    @ColumnInfo(name = COL_OWNER) var col_owner: String? = null,
    @ColumnInfo(name = COL_CITY) var col_city: String? = null,
    @ColumnInfo(name = COL_COUNTRY) var col_country: String? = null,
    @ColumnInfo(name = COL_ADDRESS) var col_address: String? = null,
    @ColumnInfo(name = COL_LAT) var col_lat: Double? = 0.0,
    @ColumnInfo(name = COL_LNG) var col_lng: Double? = 0.0,
    @ColumnInfo(name = COL_PHONE_NUMER) var col_phone: String? = null,
    @ColumnInfo(name = COL_MOBILE_NUMER) var col_mobile: String? = null,
) {
    companion object {
        const val TABLE_COMPANY = "Company"
        const val COL_BRANDNAME = "CompanyName"
        const val COL_ID = "CompanyId"
        const val COL_OWNER = "CompanyOwner"
        const val COL_IMAGE = "CompanyImage"
        const val COL_CITY = "CompanyCity"
        const val COL_COUNTRY = "CompanyCountry"
        const val COL_ADDRESS = "CompanyAddress"
        const val COL_LAT = "CompanyLat"
        const val COL_LNG = "CompanyLng"
        const val COL_PHONE_NUMER = "CompanyPhoneNumber"
        const val COL_MOBILE_NUMER = "CompanyMobileNumber"
    }

}