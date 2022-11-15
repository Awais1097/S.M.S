package com.awais.storemanagementsystem

import android.annotation.SuppressLint
import android.content.Intent
import android.os.Bundle
import android.view.Menu
import android.view.MenuItem
import android.view.View
import android.widget.Switch
import android.widget.TextView
import androidx.activity.ComponentActivity
import androidx.appcompat.app.AppCompatActivity
import androidx.core.content.ContextCompat
import androidx.drawerlayout.widget.DrawerLayout
import androidx.navigation.NavController
import androidx.navigation.findNavController
import androidx.navigation.ui.*
import com.awais.storemanagementsystem.databinding.ActivityMainBinding
import com.awais.storemanagementsystem.dbbackup.OnCompleteListener
import com.awais.storemanagementsystem.dbbackup.RoomBackup
import com.awais.storemanagementsystem.roomdb.AppDatabase
import com.awais.storemanagementsystem.util.ActivityUtils
import com.awais.storemanagementsystem.util.BottomSheet
import com.awais.storemanagementsystem.util.UserData
import com.awais.storemanagementsystem.util.Utilities
import com.google.android.material.navigation.NavigationView
import com.google.android.material.snackbar.Snackbar

class MainActivity : AppCompatActivity(), NavigationView.OnNavigationItemSelectedListener {

    private lateinit var appBarConfiguration: AppBarConfiguration
    private lateinit var binding: ActivityMainBinding
    private var navController: NavController? = null
    private var drawerLayout: DrawerLayout? = null
    lateinit var room: RoomBackup

    @SuppressLint("UseSwitchCompatOrMaterialCode")
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)

        setSupportActionBar(binding.appBarMain.toolbar)

        binding.appBarMain.fab.setOnClickListener {
            BottomSheet().show(supportFragmentManager,"Receipt")
        }
        drawerLayout = binding.drawerLayout
        val navView: NavigationView = binding.navView
        navController = findNavController(R.id.nav_host_fragment_content_main)
        // Passing each menu ID as a set of Ids because each menu should be considered as top level destinations.
        appBarConfiguration = AppBarConfiguration(setOf(R.id.nav_home), drawerLayout)
        /*, R.id.nav_products, R.id.nav_gallery, R.id.nav_slideshow,
                R.id.nav_brands, R.id.nav_rack*/
        setupActionBarWithNavController(navController!!, appBarConfiguration)
        navView.setupWithNavController(navController!!)
        navView.setNavigationItemSelectedListener(this)
        navView.itemIconTintList = null
        val user = UserData.getUser(this)
        val headerView = navView.getHeaderView(0)
        val titleTextView = headerView.findViewById<TextView>(R.id.title_text_view)
        val emailTextView = headerView.findViewById<TextView>(R.id.textView_detail)
        val switch = headerView.findViewById<Switch>(R.id.switch_view)
        titleTextView.text = user.shopName
        emailTextView.text = user.email
        switch.isChecked = !UserData.userShopOnOff(this)
        setToolBarColor(headerView)
        switch.setOnClickListener {
            UserData.saveShopOnOff(this, !switch.isChecked)
            setToolBarColor(headerView)
        }
        room = RoomBackup(this as ComponentActivity)
            .database(AppDatabase.get())
            .enableLogDebug(true)
            .backupIsEncrypted(false)
            .customBackupFileName("ShopDataBaseBackUp.sqlite")
            .backupLocation(RoomBackup.BACKUP_FILE_LOCATION_CUSTOM_DIALOG)
            .maxFileCount(1)
            .onCompleteListener(object : OnCompleteListener {
                override fun onComplete(success: Boolean, message: String, exitCode: Int) {
                    if (success) {
                        room.restartApp(Intent(applicationContext, MainActivity::class.java))
                        Utilities.showSnackbar(
                            binding.root, "Task complete successfully.", "",
                            getColor(R.color.Green)
                        ) {
                        }
                    } else {
                        Utilities.showSnackbar(
                            binding.root, "Task Canceled.", "",
                            getColor(R.color.Red)
                        ) {
                        }
                    }
                }
            })
    }

    override fun onCreateOptionsMenu(menu: Menu): Boolean {
        // Inflate the menu; this adds items to the action bar if it is present.
        // menuInflater.inflate(R.menu.main, menu)
        return true
    }

    override fun onSupportNavigateUp(): Boolean {
        val navController = findNavController(R.id.nav_host_fragment_content_main)
        return navController.navigateUp(appBarConfiguration) || super.onSupportNavigateUp()
    }

    override fun onNavigationItemSelected(menu: MenuItem): Boolean {
        menu.isChecked = true
        drawerLayout!!.closeDrawers()
        when (menu.itemId) {
            R.id.nav_logout -> {
                UserData.saveIsLogIn(this, false)
                ActivityUtils.startLoginActivity(this)
                finish()
                return true
            }
            R.id.nav_exit -> {
                finish()
                return true
            }
            R.id.nav_backup -> {
                room.backup()
                return true
            }
            R.id.nav_restore -> {
                room.restore()
                return true
            }
            R.id.nav_about -> {
                ActivityUtils.startCallActivity(
                    this, "+923066395565"
                )
                return true
            }
            R.id.nav_setting -> {
                ActivityUtils.startRegisterActivity(this, true)
                return true
            }
        }
        try {
            if (navController!!.currentDestination!!.id != menu.itemId)
                navController!!.navigate(menu.itemId)
        } catch (ex: Exception) {
            ex.printStackTrace()
        }
        return true
    }

    private fun setToolBarColor(header: View) {
        val isChecked = !UserData.userShopOnOff(this)
        binding.appBarMain.toolbar.setBackgroundColor(
            if (isChecked) getColor(R.color.purple_500) else getColor(R.color.Red)
        )
        header.background =
            if (isChecked) getDrawable(R.drawable.nav_bg) else getDrawable(R.drawable.nav_bg_red)
        /*window.navigationBarColor = ContextCompat.getColor(this,
            if (switch.isChecked) R.color.purple_500 else R.color.Red
        )*/
        window.statusBarColor = ContextCompat.getColor(
            this, if (isChecked) R.color.purple_500 else R.color.Red
        )
    }

}