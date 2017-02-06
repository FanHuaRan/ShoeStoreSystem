package com.fhr.shoestore.model;

import java.util.HashSet;
import java.util.Set;

/**
 * Shoe entity. @author MyEclipse Persistence Tools
 */

public class Shoe implements java.io.Serializable {

	// Fields

	private Long shoeId;
	private Stock stock;
	private Season season;
	private Sale sale;
	private Integer thingId;
	private String color;
	private Short size;
	private Float price;
	private Short isSell;
	private Float sellPrice;
	private Set stores = new HashSet(0);

	// Constructors

	/** default constructor */
	public Shoe() {
	}

	/** minimal constructor */
	public Shoe(Season season, Integer thingId, String color, Short size, Float price, Short isSell) {
		this.season = season;
		this.thingId = thingId;
		this.color = color;
		this.size = size;
		this.price = price;
		this.isSell = isSell;
	}

	/** full constructor */
	public Shoe(Stock stock, Season season, Sale sale, Integer thingId, String color, Short size, Float price,
			Short isSell, Float sellPrice, Set stores) {
		this.stock = stock;
		this.season = season;
		this.sale = sale;
		this.thingId = thingId;
		this.color = color;
		this.size = size;
		this.price = price;
		this.isSell = isSell;
		this.sellPrice = sellPrice;
		this.stores = stores;
	}

	// Property accessors

	public Long getShoeId() {
		return this.shoeId;
	}

	public void setShoeId(Long shoeId) {
		this.shoeId = shoeId;
	}

	public Stock getStock() {
		return this.stock;
	}

	public void setStock(Stock stock) {
		this.stock = stock;
	}

	public Season getSeason() {
		return this.season;
	}

	public void setSeason(Season season) {
		this.season = season;
	}

	public Sale getSale() {
		return this.sale;
	}

	public void setSale(Sale sale) {
		this.sale = sale;
	}

	public Integer getThingId() {
		return this.thingId;
	}

	public void setThingId(Integer thingId) {
		this.thingId = thingId;
	}

	public String getColor() {
		return this.color;
	}

	public void setColor(String color) {
		this.color = color;
	}

	public Short getSize() {
		return this.size;
	}

	public void setSize(Short size) {
		this.size = size;
	}

	public Float getPrice() {
		return this.price;
	}

	public void setPrice(Float price) {
		this.price = price;
	}

	public Short getIsSell() {
		return this.isSell;
	}

	public void setIsSell(Short isSell) {
		this.isSell = isSell;
	}

	public Float getSellPrice() {
		return this.sellPrice;
	}

	public void setSellPrice(Float sellPrice) {
		this.sellPrice = sellPrice;
	}

	public Set getStores() {
		return this.stores;
	}

	public void setStores(Set stores) {
		this.stores = stores;
	}

}