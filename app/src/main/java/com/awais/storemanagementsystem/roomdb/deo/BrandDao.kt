package com.awais.storemanagementsystem.roomdb.deo

import androidx.room.*
import androidx.room.OnConflictStrategy.Companion.IGNORE
import com.awais.storemanagementsystem.roomdb.entity.BrandEntity

@Dao
interface BrandDao {

    @Insert(entity = BrandEntity::class, onConflict = IGNORE)
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

    @Insert(entity = BrandEntity::class, onConflict = IGNORE)
    fun insertAll(users: List<BrandEntity>)

    @Query("SELECT * FROM Brands WHERE CompanyId = :pid")
    fun getByCompanyId(pid: Int): List<BrandEntity>

}