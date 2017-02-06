package com.fhr.shoestore.model;

import java.util.HashSet;
import java.util.Set;

/**
 * Customer entity. @author MyEclipse Persistence Tools
 */

public class Customer implements java.io.Serializable {

	// Fields

	private Long customerId;
	private String customerName;
	private String phone;
	private Float score;
	private Set sales = new HashSet(0);

	// Constructors

	/** default constructor */
	public Customer() {
	}

	/** minimal constructor */
	public Customer(String customerName, String phone, Float score) {
		this.customerName = customerName;
		this.phone = phone;
		this.score = score;
	}

	/** full constructor */
	public Customer(String customerName, String phone, Float score, Set sales) {
		this.customerName = customerName;
		this.phone = phone;
		this.score = score;
		this.sales = sales;
	}

	// Property accessors

	public Long getCustomerId() {
		return this.customerId;
	}

	public void setCustomerId(Long customerId) {
		this.customerId = customerId;
	}

	public String getCustomerName() {
		return this.customerName;
	}

	public void setCustomerName(String customerName) {
		this.customerName = customerName;
	}

	public String getPhone() {
		return this.phone;
	}

	public void setPhone(String phone) {
		this.phone = phone;
	}

	public Float getScore() {
		return this.score;
	}

	public void setScore(Float score) {
		this.score = score;
	}

	public Set getSales() {
		return this.sales;
	}

	public void setSales(Set sales) {
		this.sales = sales;
	}

}