package com.awais.storemanagementsystem.ui

import android.app.Activity
import android.content.Intent
import android.os.Bundle
import android.text.TextUtils
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Toast
import androidx.core.graphics.drawable.toBitmap
import androidx.core.view.isVisible
import androidx.fragment.app.Fragment
import androidx.lifecycle.ViewModelProvider
import androidx.recyclerview.widget.LinearLayoutManager
import com.awais.route.imagepicker.ImagePicker
import com.awais.storemanagementsystem.R
import com.awais.storemanagementsystem.adapter.RackListAdapter
import com.awais.storemanagementsystem.databinding.FragmentBrandBinding
import com.awais.storemanagementsystem.roomdb.AppDatabase
import com.awais.storemanagementsystem.roomdb.entity.RacksEntity
import com.awais.storemanagementsystem.util.Utilities
import com.awais.storemanagementsystem.util.Utilities.decode
import com.awais.storemanagementsystem.viewmodel.RacksViewModel
import com.bumptech.glide.Glide

class RackFragment : Fragment() {

    private var _binding: FragmentBrandBinding? = null
    // This property is only valid between onCreateView and onDestroyView.
    private var uri: String? = null
    private val binding get() = _binding!!
    var mItem = RacksEntity()

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?
    ): View {
        val viewModel =
            ViewModelProvider(this)[RacksViewModel::class.java]
        _binding = FragmentBrandBinding.inflate(inflater, container, false)
        binding.addImage.setOnClickListener {
            ImagePicker.with(this).cameraOnly().crop().start()
        }
        binding.titleTextView.text =  requireContext().getString(R.string.add_new_rack)
        binding.brandNameEditText.hint = requireContext().getString(R.string.rack_title)
        binding.brandMv.setImageDrawable(requireContext().getDrawable(R.drawable.rank_icon))
        binding.imageViewPring.isVisible = true
        binding.recyclerView.layoutManager = LinearLayoutManager(requireContext())
        viewModel.list.observe(viewLifecycleOwner) {
            binding.recyclerView.adapter = RackListAdapter(it,
                onItemClick = object : RackListAdapter.OnItemClick {

                    override fun onDelete(item: RacksEntity) {
                        deleteBrand(item)
                        viewModel.getAll()
                    }

                    override fun onClick(item: RacksEntity) {
                        mItem = item
                        binding.brandNameEditText.setText(item.col_rackname)
                        if (item.col_image != null) {
                            Glide.with(requireContext()).load(decode(item.col_image!!)).centerCrop()
                                .into(binding.imageView)
                        }
                        uri = item.col_image
                    }

                    override fun onPrint(item: RacksEntity) {
                        
                    }
                }
            )
            binding.countTv.text =
                "${requireContext().getString(R.string.all_racks)} (${it.size})"
        }
        binding.saveButton.setOnClickListener {
            if (TextUtils.isEmpty(binding.brandNameEditText.text)) {
                Toast.makeText(requireContext(), "Enter Name", Toast.LENGTH_SHORT).show()
                return@setOnClickListener
            }
            if (uri == null) {
                Toast.makeText(requireContext(), "Select Image", Toast.LENGTH_SHORT).show()
                return@setOnClickListener
            }
            saveBrand()
            viewModel.getAll()
            binding.brandNameEditText.text = null
            uri = null
            binding.imageView.setImageDrawable(null)
            mItem._id = null
        }
        return binding.root
    }

    override fun onDestroyView() {
        super.onDestroyView()
        _binding = null
    }

    override fun onActivityResult(requestCode: Int, resultCode: Int, data: Intent?) {
        super.onActivityResult(requestCode, resultCode, data)
        when (resultCode) {
            Activity.RESULT_OK -> {
                val d = data?.data!!
                Glide.with(this).load(d).centerCrop()
                    .placeholder(R.drawable.brand_icon).into(binding.imageView)
                uri =  Utilities.encode(binding.imageView.drawable.toBitmap())
            }
            ImagePicker.RESULT_ERROR -> {
                Toast.makeText(requireContext(), ImagePicker.getError(data), Toast.LENGTH_SHORT)
                    .show()
            }
            else -> {
                Toast.makeText(requireContext(), "Task Cancelled", Toast.LENGTH_SHORT).show()
            }
        }
    }

    private fun saveBrand() {
        try {
            mItem.col_rackname = binding.brandNameEditText.text.toString()
            mItem.col_image = Utilities.encode(binding.imageView.drawable.toBitmap())
            if(mItem.col_rackid == null){
                mItem.col_rackid = "RACK-${(binding.recyclerView.adapter?.itemCount ?: 0) + 1}"
            }
            AppDatabase.get().racksDao().insert(mItem)
            Utilities.showSnackbar(binding.root, "Rack Saved", null, R.color.Green)
        } catch (ex: Exception) {
            Utilities.showSnackbar(binding.root, "Rack Not Saved", null, R.color.Red)
        }
    }

    private fun deleteBrand(item: RacksEntity) {
        try {
            AppDatabase.get().racksDao().delete(item)
            Utilities.showSnackbar(binding.root, "Rack Deleted", null, R.color.Green)
        } catch (ex: Exception) {
            Utilities.showSnackbar(binding.root, "Rack Not Deleted", null, R.color.Red)
        }
    }

}