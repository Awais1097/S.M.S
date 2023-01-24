package com.awais.storemanagementsystem.roomdb.entity

import androidx.room.ColumnInfo
import androidx.room.Entity
import androidx.room.PrimaryKey
import com.awais.storemanagementsystem.roomdb.entity.BrandEntity.Companion.COL_IMAGE
import com.awais.storemanagementsystem.roomdb.entity.RacksEntity.Companion.TABLE_RACKS

@Entity(tableName = TABLE_RACKS)
class RacksEntity(
    @PrimaryKey(autoGenerate = true) var _id: Int? = null,
    @ColumnInfo(name = COL_RACKNAME) var col_rackname: String?= null,
    @ColumnInfo(name = COL_RACKID) var col_rackid: String? = null,
    @ColumnInfo(name = COL_IMAGE) var col_image : String? = null,
) {
    companion object {
        const val TABLE_RACKS = "Racks"
        const val COL_RACKNAME = "RackName"
        const val COL_RACKID = "RackId"
    }

}