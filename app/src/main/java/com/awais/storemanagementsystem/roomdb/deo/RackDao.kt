package com.awais.storemanagementsystem.roomdb.deo

import androidx.room.*
import androidx.room.OnConflictStrategy.Companion.IGNORE
import com.awais.storemanagementsystem.roomdb.entity.RacksEntity

@Dao
interface RackDao {

    @Insert(entity = RacksEntity::class, onConflict = IGNORE)
    fun insert(user: RacksEntity?)

    @Query("DELETE FROM Racks WHERE _id =:Id")
    fun delete(Id: Int)

    @Update
    fun updateUsers(vararg users: RacksEntity)

    @Delete
    fun delete(user: RacksEntity)

    @Query("DELETE FROM Racks")
    fun deleteAll()

    @Query("SELECT * FROM Racks order by _id")
    fun getAll(): List<RacksEntity>

    @Query("SELECT * FROM Racks WHERE _id = :pid")
    fun getById(pid: Int): RacksEntity

    @Insert(entity = RacksEntity::class, onConflict = IGNORE)
    fun insertAll(users: List<RacksEntity>)

}