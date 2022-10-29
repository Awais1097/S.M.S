package com.awais.storemanagementsystem.calender.ui

import android.view.View
import com.awais.storemanagementsystem.calender.model.CalendarDay
import com.awais.storemanagementsystem.calender.model.CalendarMonth

open class ViewContainer(val view: View)

interface DayBinder<T : ViewContainer> {
    fun create(view: View): T
    fun bind(container: T, day: CalendarDay)
}

interface MonthHeaderFooterBinder<T : ViewContainer> {
    fun create(view: View): T
    fun bind(container: T, month: CalendarMonth)
}

typealias MonthScrollListener = (CalendarMonth) -> Unit
