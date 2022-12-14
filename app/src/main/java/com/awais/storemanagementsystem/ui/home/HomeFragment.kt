package com.awais.storemanagementsystem.ui.home

import android.annotation.SuppressLint
import android.os.Bundle
import android.util.Log
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.core.view.size
import androidx.fragment.app.Fragment
import androidx.lifecycle.ViewModelProvider
import com.awais.storemanagementsystem.R
import com.awais.storemanagementsystem.databinding.FragmentHomeBinding
import com.awais.storemanagementsystem.ui.ProductsListFragment
import com.awais.storemanagementsystem.util.ActivityUtils
import com.awais.storemanagementsystem.util.UserData
import com.awais.storemanagementsystem.util.Utilities
import com.google.android.gms.ads.AdRequest
import com.google.android.gms.ads.AdSize
import com.google.android.gms.ads.MobileAds
import com.google.android.gms.ads.RequestConfiguration
import java.text.SimpleDateFormat
import java.util.*

@SuppressLint("NewApi")
class HomeFragment : Fragment() {

    private var _binding: FragmentHomeBinding? = null
    // This property is only valid between onCreateView and onDestroyView.
    private val binding get() = _binding!!

    @SuppressLint("SetTextI18n", "SimpleDateFormat")
    override fun onCreateView(
        inflater: LayoutInflater,
        container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View {
        val homeViewModel =
            ViewModelProvider(this)[HomeViewModel::class.java]

        _binding = FragmentHomeBinding.inflate(inflater, container, false)
        val root: View = binding.root
        MobileAds.initialize(requireContext()){}
      //  binding.adView.setAdSize(AdSize.BANNER) =
        Log.d("Ads", "Google Mobile Ads SDK Version: " + MobileAds.getVersion())
        val adRequest = AdRequest.Builder().build()
        binding.adView.loadAd(adRequest)
        val user = UserData.getUser(requireContext())
        binding.userNameTv.text = user.ownerName
        binding.todayTv.text = SimpleDateFormat("EEEE, dd MMM, yyyy").format(Date()).toString()
        binding.tagetTv.text = Utilities.withSuffix(
            user.dailyTargetMin?.toLong() ?: 0
        ) + " To " + Utilities.withSuffix(user.dailyTargetMax?.toLong() ?: 0)
        binding.priductsCard.setOnClickListener {
            ActivityUtils.startFrameActivity(
                requireContext(),getString(R.string.products),ProductsListFragment.TAG
            )
        }
        /* val mBarChart1 = BarChart(requireContext())//binding.aaChartView
         val layoutParams = LinearLayout.LayoutParams(LinearLayout.LayoutParams.MATCH_PARENT, 350)
         mBarChart1.setLayoutParams(layoutParams)
         val mBarChart2 = BarChart(requireContext())//binding.aaChartView
         mBarChart2.setLayoutParams(layoutParams)
         mBarChart1.addBar(BarModel("Jan", 2.3f, -0xedcbaa))
         mBarChart1.addBar(BarModel("Feb", 2f, -0xcbcbaa))
         mBarChart1.addBar(BarModel("Mar", 3.3f, -0xa9cbaa))
         mBarChart1.addBar(BarModel("Apr", 1.1f, -0x78c0aa))
         mBarChart1.addBar(BarModel("Mai", 2.7f, -0xa9480f))
         mBarChart1.addBar(BarModel("Jun", 2f, -0xcbcbaa))
         mBarChart2.addBar(BarModel("Jul", 0.4f, -0xe00b54))
         mBarChart2.addBar(BarModel("Aug", 4f, -0xe45b1a))
         mBarChart2.addBar(BarModel("Sep", 4f, -0xe45b1a))
         mBarChart2.addBar(BarModel("Oct", 4f, -0xe45b1a))
         mBarChart2.addBar(BarModel("Nov", 4f, -0xe45b1a))
         mBarChart2.addBar(BarModel("Dec", 4f, -0xe45b1a))
         mBarChart1.startAnimation()
         mBarChart2.startAnimation()
         binding.chartView.addView(mBarChart1)
         binding.chartView.addView(mBarChart2)*/
        return root
    }

    override fun onDestroyView() {
        super.onDestroyView()
        binding.adView.destroy()
        _binding = null
    }

    override fun onPause() {
        binding.adView.pause()
        super.onPause()
    }

    override fun onResume() {
        binding.adView.resume()
        super.onResume()
    }
}