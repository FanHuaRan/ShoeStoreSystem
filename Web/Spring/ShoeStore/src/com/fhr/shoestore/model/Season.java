package com.fhr.shoestore.model;

import java.util.HashSet;
import java.util.Set;

/**
 * Season entity. @author MyEclipse Persistence Tools
 */

public class Season implements java.io.Serializable {

	// Fields

	private Integer seasonId;
	private String seasonName;
	private Set shoes = new HashSet(0);

	// Constructors

	/** default constructor */
	public Season() {
	}

	/** minimal constructor */
	public Season(String seasonName) {
		this.seasonName = seasonName;
	}

	/** full constructor */
	public Season(String seasonName, Set shoes) {
		this.seasonName = seasonName;
		this.shoes = shoes;
	}

	// Property accessors

	public Integer getSeasonId() {
		return this.seasonId;
	}

	public void setSeasonId(Integer seasonId) {
		this.seasonId = seasonId;
	}

	public String getSeasonName() {
		return this.seasonName;
	}

	public void setSeasonName(String seasonName) {
		this.seasonName = seasonName;
	}

	public Set getShoes() {
		return this.shoes;
	}

	public void setShoes(Set shoes) {
		this.shoes = shoes;
	}

}