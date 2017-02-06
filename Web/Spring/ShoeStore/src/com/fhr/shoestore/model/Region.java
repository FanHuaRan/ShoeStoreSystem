package com.fhr.shoestore.model;

import java.util.HashSet;
import java.util.Set;

/**
 * Region entity. @author MyEclipse Persistence Tools
 */

public class Region implements java.io.Serializable {

	// Fields

	private Integer regionId;
	private String regionName;
	private String regionAddress;
	private Set stores = new HashSet(0);

	// Constructors

	/** default constructor */
	public Region() {
	}

	/** minimal constructor */
	public Region(String regionName, String regionAddress) {
		this.regionName = regionName;
		this.regionAddress = regionAddress;
	}

	/** full constructor */
	public Region(String regionName, String regionAddress, Set stores) {
		this.regionName = regionName;
		this.regionAddress = regionAddress;
		this.stores = stores;
	}

	// Property accessors

	public Integer getRegionId() {
		return this.regionId;
	}

	public void setRegionId(Integer regionId) {
		this.regionId = regionId;
	}

	public String getRegionName() {
		return this.regionName;
	}

	public void setRegionName(String regionName) {
		this.regionName = regionName;
	}

	public String getRegionAddress() {
		return this.regionAddress;
	}

	public void setRegionAddress(String regionAddress) {
		this.regionAddress = regionAddress;
	}

	public Set getStores() {
		return this.stores;
	}

	public void setStores(Set stores) {
		this.stores = stores;
	}

}