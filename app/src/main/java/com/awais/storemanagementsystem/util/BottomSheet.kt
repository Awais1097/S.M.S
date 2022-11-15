package com.awais.storemanagementsystem.util

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import com.awais.storemanagementsystem.databinding.CreateReceiptBottomSheetLayoutBinding
import com.google.android.material.bottomsheet.BottomSheetDialogFragment

class BottomSheet :BottomSheetDialogFragment() {

    var _binding :CreateReceiptBottomSheetLayoutBinding? = null
    val binding get() = _binding!!

    override fun onCreateView(
        inflater: LayoutInflater,
        container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        _binding = CreateReceiptBottomSheetLayoutBinding.inflate(inflater,container,false)
        return _binding?.root
    }


    override fun onDestroy() {
        super.onDestroy()
        _binding = null
    }

}