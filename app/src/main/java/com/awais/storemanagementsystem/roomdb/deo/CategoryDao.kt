package com.awais.storemanagementsystem.roomdb.deo

import androidx.room.*
import androidx.room.OnConflictStrategy.Companion.IGNORE
import com.awais.storemanagementsystem.roomdb.entity.Categoryntity

@Dao
interface CategoryDao {

    @Insert(entity = Categoryntity::class, onConflict = IGNORE)
    fun insert(user: Categoryntity?)

    @Query("DELETE FROM Category WHERE _id =:Id")
    fun delete(Id: Int)

    @Update
    fun updateUsers(vararg users: Categoryntity)

    @Delete
    fun delete(user: Categoryntity)

    @Query("DELETE FROM Category")
    fun deleteAll()

    @Query("SELECT * FROM Category order by _id")
    fun getAll(): List<Categoryntity>

    @Query("SELECT * FROM Category WHERE _id = :pid")
    fun getById(pid: Int): Categoryntity

    @Insert(entity = Categoryntity::class, onConflict = IGNORE)
    fun insertAll(users: List<Categoryntity>)

}