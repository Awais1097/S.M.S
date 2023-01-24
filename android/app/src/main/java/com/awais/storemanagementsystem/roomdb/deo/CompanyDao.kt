package com.awais.storemanagementsystem.roomdb.deo

import androidx.room.*
import androidx.room.OnConflictStrategy.Companion.IGNORE
import com.awais.storemanagementsystem.roomdb.entity.CompanyEntity

@Dao
interface CompanyDao {

    @Insert(entity = CompanyEntity::class, onConflict = OnConflictStrategy.REPLACE)
    fun insert(user: CompanyEntity?)

    @Query("DELETE FROM Company WHERE CompanyId =:Id")
    fun delete(Id: Int)

    @Update
    fun updateUsers(vararg users: CompanyEntity)

    @Delete
    fun delete(user: CompanyEntity)

    @Query("DELETE FROM Company")
    fun deleteAll()

    @Query("SELECT * FROM Company order by CompanyId")
    fun getAll(): List<CompanyEntity>

    @Insert(entity = CompanyEntity::class, onConflict = OnConflictStrategy.REPLACE)
    fun insertAll(users: List<CompanyEntity>)

    @Query("SELECT * FROM Company WHERE CompanyId = :pid")
    fun getByCompanyId(pid: Int): List<CompanyEntity>

}