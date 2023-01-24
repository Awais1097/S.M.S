package com.awais.storemanagementsystem.roomdb.deo

import androidx.room.*
import androidx.room.OnConflictStrategy.Companion.IGNORE
import androidx.room.OnConflictStrategy.Companion.REPLACE
import com.awais.storemanagementsystem.roomdb.entity.BrandEntity

@Dao
interface BrandDao {

    @Insert(entity = BrandEntity::class, onConflict = REPLACE)
    fun insert(user: BrandEntity?)

    @Query("DELETE FROM Brands WHERE _id =:Id")
    fun delete(Id: Int)

    @Update
    fun updateUsers(vararg users: BrandEntity)

    @Delete
    fun delete(user: BrandEntity)

    @Query("DELETE FROM Brands")
    fun deleteAll()

    @Query("SELECT * FROM Brands order by _id")
    fun getAll(): List<BrandEntity>

    @Query("SELECT * FROM Brands WHERE _id = :pid")
    fun getById(pid: Int): BrandEntity

    @Insert(entity = BrandEntity::class, onConflict = REPLACE)
    fun insertAll(users: List<BrandEntity>)

}