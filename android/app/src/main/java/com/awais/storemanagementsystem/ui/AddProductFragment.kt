package com.awais.storemanagementsystem.ui

import android.annotation.SuppressLint
import android.app.Activity
import android.content.Intent
import android.os.Bundle
import android.text.TextUtils
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.ArrayAdapter
import android.widget.Toast
import androidx.core.graphics.drawable.toBitmap
import androidx.fragment.app.Fragment
import androidx.lifecycle.ViewModelProvider
import androidx.recyclerview.widget.LinearLayoutManager
import com.awais.route.imagepicker.ImagePicker
import com.awais.storemanagementsystem.R
import com.awais.storemanagementsystem.adapter.ProductsListAdapter
import com.awais.storemanagementsystem.databinding.FragmentAddProductsBinding
import com.awais.storemanagementsystem.roomdb.AppDatabase
import com.awais.storemanagementsystem.roomdb.entity.*
import com.awais.storemanagementsystem.util.ActivityUtils
import com.awais.storemanagementsystem.util.Utilities
import com.awais.storemanagementsystem.util.Utilities.decode
import com.awais.storemanagementsystem.viewmodel.ProductsViewModel
import com.bumptech.glide.Glide

class AddProductFragment : Fragment() {

    private var _binding: FragmentAddProductsBinding? = null
    private var uri: String? = null
    private val binding get() = _binding!!
    var mItem = ProductEntity()

    private var bracndNames = ArrayList<String>()
    private var rackNames = ArrayList<String>()
    private var catsNames = ArrayList<String>()
    private var compNames = ArrayList<String>()

    private var bracndsList: List<BrandEntity> = ArrayList()
    private var racksList: List<RacksEntity> = ArrayList()
    private var catssList: List<Categoryntity> = ArrayList()
    private var compList: List<CompanyEntity> = ArrayList()

    @SuppressLint("SetTextI18n", "UseCompatLoadingForDrawables")
    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?
    ): View {
        val viewModel =
            ViewModelProvider(this)[ProductsViewModel::class.java]
        _binding = FragmentAddProductsBinding.inflate(inflater, container, false)
        binding.addImage.setOnClickListener {
            ImagePicker.with(this).cameraOnly().crop().start()
        }
        binding.recyclerView.layoutManager = LinearLayoutManager(requireContext())
        viewModel.getAllProducts()
        viewModel.getAllBrands()
        viewModel.getAllRack()
        viewModel.getAllCategory()
        viewModel.list_brand.observe(viewLifecycleOwner) { list ->
            bracndNames.clear()
            list?.forEach {
                bracndNames.add(it._id.toString() + " - " + it.col_branchname)
            }
            bracndsList = list ?: emptyList()
            val adpater =
                ArrayAdapter(requireContext(), R.layout.text_item_layout, R.id.text1, bracndNames)
            binding.brandNameEditText.threshold = 1
            binding.brandNameEditText.setAdapter(adpater)
        }
        viewModel.list_rack.observe(viewLifecycleOwner) { list ->
            rackNames.clear()
            list?.forEach {
                rackNames.add(it.col_rackid.toString() + " - " + it.col_rackname)
            }
            racksList = list ?: emptyList()
            val adpater =
                ArrayAdapter(requireContext(), R.layout.text_item_layout, R.id.text1, rackNames)
            binding.rackNameEditText.threshold = 1
            binding.rackNameEditText.setAdapter(adpater)
        }
        viewModel.list_catg.observe(viewLifecycleOwner) { list ->
            catsNames.clear()
            list?.forEach {
                catsNames.add(it._id.toString() + " - " + it.col_name)
            }
            catssList = list ?: emptyList()
            val adpater =
                ArrayAdapter(requireContext(), R.layout.text_item_layout, R.id.text1, catsNames)
            binding.categoryEditText.threshold = 1
            binding.categoryEditText.setAdapter(adpater)
        }
        viewModel.list_comp.observe(viewLifecycleOwner) { list ->
            compNames.clear()
            list?.forEach {
                compNames.add(it.col_id.toString() + " - " + it.col_name)
            }
            compList = list ?: emptyList()
            val adpater =
                ArrayAdapter(requireContext(), R.layout.text_item_layout, R.id.text1, compNames)
            binding.companyEditText.threshold = 1
            binding.companyEditText.setAdapter(adpater)
        }
        viewModel.list.observe(viewLifecycleOwner) {
          /*  binding.recyclerView.adapter = ProductsListAdapter(it,
                onItemClick = object : ProductsListAdapter.OnItemClick {

                    override fun onDelete(item: ProductEntity) {
                        deleteBrand(item)
                        viewModel.getAllProducts()
                    }

                    override fun onClick(item: ProductEntity) {
                        mItem = item
                        binding.productNameEditText.setText(item.col_productname)
                        binding.unitPriceEditText.setText(item.col_unitprice.toString())
                        binding.uomEditText.setText(item.col_retailprice.toString())
                        binding.sizeEditText.setText(item.col_unitsize.toString())
                        binding.cortoonSizeEditText.setText(item.col_cartonsize.toString())
                        binding.idTextView.text = item.col_productid
                        binding.brandNameEditText.setText(item.col_brandid.toString() + " - " + item.col_brandname)
                        binding.categoryEditText.setText(item.col_categoryid.toString() + " - " + item.col_categoryname)
                        binding.rackNameEditText.setText(item.col_rackid.toString() + " - " + item.col_rackname)
                        binding.companyEditText.setText(item.col_compid.toString() + " - " + item.col_compname)
                        if (item.col_img != null) {
                            Glide.with(requireContext()).load(decode(item.col_img!!)).centerCrop()
                                .into(binding.imageView)
                        }
                        uri = item.col_img
                    }
                }
            )
            binding.countTv.text =
                "${requireContext().getString(R.string.all_products)} (${it.size})"*/
        }
        binding.saveButton.setOnClickListener {
            if (TextUtils.isEmpty(binding.productNameEditText.text)) {
                Toast.makeText(requireContext(), "Enter Name", Toast.LENGTH_SHORT).show()
                return@setOnClickListener
            }
            if (TextUtils.isEmpty(binding.unitPriceEditText.text)) {
                Toast.makeText(requireContext(), "Enter Unit Price", Toast.LENGTH_SHORT).show()
                return@setOnClickListener
            }
            if (TextUtils.isEmpty(binding.uomEditText.text)) {
                Toast.makeText(requireContext(), "Enter Retail Price", Toast.LENGTH_SHORT).show()
                return@setOnClickListener
            }
            if (uri == null) {
                Toast.makeText(requireContext(), "Select Image", Toast.LENGTH_SHORT).show()
                return@setOnClickListener
            }
            saveBrand()
            viewModel.getAllProducts()
            binding.productNameEditText.text = null
            uri = null
            binding.imageView.setImageDrawable(requireContext().getDrawable(R.drawable.empty_img_icon))
            mItem._id = null
        }
        binding.seeAll.setOnClickListener {
            ActivityUtils.startFrameActivity(
                requireContext(),getString(R.string.products),ProductsListFragment.TAG
            )
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
                uri = Utilities.encode(binding.imageView.drawable.toBitmap())
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
            mItem.col_productname = binding.productNameEditText.text.toString()
            mItem.col_unitprice = binding.unitPriceEditText.text.toString().toDouble()
            mItem.col_unitsize = binding.sizeEditText.text.toString()
            mItem.col_cartonsize = binding.cortoonSizeEditText.text.toString()
            mItem.col_retailprice = binding.uomEditText.text.toString().toDouble()
            mItem.col_img = Utilities.encode(binding.imageView.drawable.toBitmap())
            val brand = bracndsList.find {
                it._id.toString() + " - " + it.col_branchname == binding.brandNameEditText.text.toString()
            }
            if (brand != null) {
                mItem.col_brandid = brand._id
                mItem.col_brandname = brand.col_branchname
            }

            val rack = racksList.find {
                it.col_rackid.toString() + " - " + it.col_rackname == binding.rackNameEditText.text.toString()
            }
            if (rack != null) {
                mItem.col_rackid = rack.col_rackid
                mItem.col_rackname = rack.col_rackname
            }

            val cate = catssList.find {
                it._id.toString() + " - " + it.col_name == binding.categoryEditText.text.toString()
            }
            if (cate != null) {
                mItem.col_categoryid = cate._id
                mItem.col_categoryname = cate.col_name
            }
            val comp = compList.find {
                it.col_id.toString() + " - " + it.col_name == binding.companyEditText.text.toString()
            }
            if (comp != null) {
                mItem.col_compid = comp.col_id
                mItem.col_compname = comp.col_name
            }

            if (mItem.col_productid == null) {
                mItem.col_productid = "PRO-${(binding.recyclerView.adapter?.itemCount ?: 0) + 1}"
            }
            AppDatabase.get().productsDao().insert(mItem)
            Utilities.showSnackbar(binding.root, "Product Saved", null, R.color.Green)
        } catch (ex: Exception) {
            Utilities.showSnackbar(binding.root, "Product Not Saved", null, R.color.Red)
        }
    }

    private fun deleteBrand(item: ProductEntity) {
        try {
            AppDatabase.get().productsDao().delete(item)
            Utilities.showSnackbar(binding.root, "Product Deleted", null, R.color.Green)
        } catch (ex: Exception) {
            Utilities.showSnackbar(binding.root, "Product Not Deleted", null, R.color.Red)
        }
    }

}