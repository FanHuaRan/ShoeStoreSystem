package com.fhr.shoestore.model;

import java.sql.Timestamp;
import java.util.HashSet;
import java.util.Set;

/**
 * Stock entity. @author MyEclipse Persistence Tools
 */

public class Stock implements java.io.Serializable {

	// Fields

	private Long stockId;
	private Stockcompany stockcompany;
	private Timestamp stockTime;
	private Integer stockCount;
	private Set shoes = new HashSet(0);

	// Constructors

	/** default constructor */
	public Stock() {
	}

	/** minimal constructor */
	public Stock(Stockcompany stockcompany, Timestamp stockTime, Integer stockCount) {
		this.stockcompany = stockcompany;
		this.stockTime = stockTime;
		this.stockCount = stockCount;
	}

	/** full constructor */
	public Stock(Stockcompany stockcompany, Timestamp stockTime, Integer stockCount, Set shoes) {
		this.stockcompany = stockcompany;
		this.stockTime = stockTime;
		this.stockCount = stockCount;
		this.shoes = shoes;
	}

	// Property accessors

	public Long getStockId() {
		return this.stockId;
	}

	public void setStockId(Long stockId) {
		this.stockId = stockId;
	}

	public Stockcompany getStockcompany() {
		return this.stockcompany;
	}

	public void setStockcompany(Stockcompany stockcompany) {
		this.stockcompany = stockcompany;
	}

	public Timestamp getStockTime() {
		return this.stockTime;
	}

	public void setStockTime(Timestamp stockTime) {
		this.stockTime = stockTime;
	}

	public Integer getStockCount() {
		return this.stockCount;
	}

	public void setStockCount(Integer stockCount) {
		this.stockCount = stockCount;
	}

	public Set getShoes() {
		return this.shoes;
	}

	public void setShoes(Set shoes) {
		this.shoes = shoes;
	}

}