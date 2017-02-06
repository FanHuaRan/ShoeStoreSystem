package com.fhr.shoestore.model;

import java.sql.Timestamp;
import java.util.HashSet;
import java.util.Set;

/**
 * Sale entity. @author MyEclipse Persistence Tools
 */

public class Sale implements java.io.Serializable {

	// Fields

	private Long saleId;
	private Customer customer;
	private String phone;
	private Timestamp saleTime;
	private Float totalPrice;
	private Set shoes = new HashSet(0);

	// Constructors

	/** default constructor */
	public Sale() {
	}

	/** minimal constructor */
	public Sale(Timestamp saleTime) {
		this.saleTime = saleTime;
	}

	/** full constructor */
	public Sale(Customer customer, String phone, Timestamp saleTime, Float totalPrice, Set shoes) {
		this.customer = customer;
		this.phone = phone;
		this.saleTime = saleTime;
		this.totalPrice = totalPrice;
		this.shoes = shoes;
	}

	// Property accessors

	public Long getSaleId() {
		return this.saleId;
	}

	public void setSaleId(Long saleId) {
		this.saleId = saleId;
	}

	public Customer getCustomer() {
		return this.customer;
	}

	public void setCustomer(Customer customer) {
		this.customer = customer;
	}

	public String getPhone() {
		return this.phone;
	}

	public void setPhone(String phone) {
		this.phone = phone;
	}

	public Timestamp getSaleTime() {
		return this.saleTime;
	}

	public void setSaleTime(Timestamp saleTime) {
		this.saleTime = saleTime;
	}

	public Float getTotalPrice() {
		return this.totalPrice;
	}

	public void setTotalPrice(Float totalPrice) {
		this.totalPrice = totalPrice;
	}

	public Set getShoes() {
		return this.shoes;
	}

	public void setShoes(Set shoes) {
		this.shoes = shoes;
	}

}