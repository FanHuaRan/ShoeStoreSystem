package com.fhr.shoestore.model;

/**
 * Store entity. @author MyEclipse Persistence Tools
 */

public class Store implements java.io.Serializable {

	// Fields

	private Long storeId;
	private Region region;
	private Shoe shoe;
	private String moreInfo;

	// Constructors

	/** default constructor */
	public Store() {
	}

	/** minimal constructor */
	public Store(Region region, Shoe shoe) {
		this.region = region;
		this.shoe = shoe;
	}

	/** full constructor */
	public Store(Region region, Shoe shoe, String moreInfo) {
		this.region = region;
		this.shoe = shoe;
		this.moreInfo = moreInfo;
	}

	// Property accessors

	public Long getStoreId() {
		return this.storeId;
	}

	public void setStoreId(Long storeId) {
		this.storeId = storeId;
	}

	public Region getRegion() {
		return this.region;
	}

	public void setRegion(Region region) {
		this.region = region;
	}

	public Shoe getShoe() {
		return this.shoe;
	}

	public void setShoe(Shoe shoe) {
		this.shoe = shoe;
	}

	public String getMoreInfo() {
		return this.moreInfo;
	}

	public void setMoreInfo(String moreInfo) {
		this.moreInfo = moreInfo;
	}

}