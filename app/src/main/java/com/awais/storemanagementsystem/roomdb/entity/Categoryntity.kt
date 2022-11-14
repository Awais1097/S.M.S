package com.awais.storemanagementsystem.roomdb.entity

import androidx.room.ColumnInfo
import androidx.room.Entity
import androidx.room.PrimaryKey
import com.awais.storemanagementsystem.roomdb.entity.Categoryntity.Companion.TABLE_CATEGORY

@Entity(tableName = TABLE_CATEGORY)
class Categoryntity(
    @PrimaryKey(autoGenerate = true) var _id: Int? = null,
    @ColumnInfo(name = COL_BRANDNAME) var col_name: String? = null,
    @ColumnInfo(name = COL_IMAGE) var col_imge: String? = null,
) {
    companion object {
        const val TABLE_CATEGORY = "Category"
        const val COL_BRANDNAME = "CategoryName"
        const val COL_IMAGE = "BrandImage"
    }

}