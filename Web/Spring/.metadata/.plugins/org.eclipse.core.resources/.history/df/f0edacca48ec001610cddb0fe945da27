package com.fhr.shoestore.model;

import java.util.HashSet;
import java.util.Set;

/**
 * Stockcompany entity. @author MyEclipse Persistence Tools
 */

public class Stockcompany implements java.io.Serializable {

	// Fields

	private Integer stockCompanyId;
	private String stockCompanyName;
	private Set stocks = new HashSet(0);

	// Constructors

	/** default constructor */
	public Stockcompany() {
	}

	/** minimal constructor */
	public Stockcompany(String stockCompanyName) {
		this.stockCompanyName = stockCompanyName;
	}

	/** full constructor */
	public Stockcompany(String stockCompanyName, Set stocks) {
		this.stockCompanyName = stockCompanyName;
		this.stocks = stocks;
	}

	// Property accessors

	public Integer getStockCompanyId() {
		return this.stockCompanyId;
	}

	public void setStockCompanyId(Integer stockCompanyId) {
		this.stockCompanyId = stockCompanyId;
	}

	public String getStockCompanyName() {
		return this.stockCompanyName;
	}

	public void setStockCompanyName(String stockCompanyName) {
		this.stockCompanyName = stockCompanyName;
	}

	public Set getStocks() {
		return this.stocks;
	}

	public void setStocks(Set stocks) {
		this.stocks = stocks;
	}

}