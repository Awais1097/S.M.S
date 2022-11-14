package com.awais.storemanagementsystem.roomdb.entity

import androidx.room.ColumnInfo
import androidx.room.Entity
import androidx.room.PrimaryKey
import com.awais.storemanagementsystem.roomdb.entity.BrandEntity.Companion.TABLE_BRAND

@Entity(tableName = TABLE_BRAND)
class BrandEntity(
    @PrimaryKey(autoGenerate = true) var _id: Int? = null,
    @ColumnInfo(name = COL_BRANDNAME) var col_branchname: String?= null,
    @ColumnInfo(name = COL_IMAGE) var col_imge: String? = null,
) {
    companion object {
        const val TABLE_BRAND = "Brands"
        const val COL_BRANDNAME = "BranchName"
        const val COL_IMAGE = "BrandImage"
    }

}