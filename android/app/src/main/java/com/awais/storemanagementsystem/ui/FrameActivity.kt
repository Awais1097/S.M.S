package com.awais.storemanagementsystem.ui

import android.annotation.SuppressLint
import android.content.Context
import com.awais.storemanagementsystem.util.Utilities.initFragment
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.content.Intent
import com.awais.storemanagementsystem.R
import com.google.android.material.appbar.MaterialToolbar

class FrameActivity : AppCompatActivity() {
    @SuppressLint("NewApi", "UseCompatLoadingForDrawables")
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_base)
        val toolbar = findViewById<MaterialToolbar>(R.id.toolbar)
        setSupportActionBar(toolbar)
        val title = intent.getStringExtra(KEY_TITLE)
        supportActionBar?.title = title
        toolbar.navigationIcon =
            getDrawable(androidx.appcompat.R.drawable.abc_ic_ab_back_material)
        toolbar.setNavigationIconTint(getColor(R.color.white))
        toolbar.setNavigationOnClickListener {
            finish()
        }
        // this is because if activity recreated
        if (savedInstanceState != null) return
        supportFragmentManager.beginTransaction().replace(
            R.id.base_container, initFragment(
                supportFragmentManager.fragmentFactory,
                intent.getStringExtra(KEY_FRAGMENT)!!, intent.extras
            )
        )
            .commit()
    }

    companion object {
        const val KEY_TITLE = "title"
        const val KEY_FRAGMENT = "fragment"
        fun createIntent(
            context: Context?,
            title: String?,
            fragment: String?,
            extras: Bundle?
        ): Intent {
            return Intent(context, FrameActivity::class.java).putExtra(KEY_TITLE, title)
                .putExtra(KEY_FRAGMENT, fragment).putExtras(extras!!)
        }
    }
}