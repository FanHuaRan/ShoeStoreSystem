package com.fhr.shoestore.dao;

import java.util.List;
import java.util.Set;
import org.apache.commons.logging.Log;
import org.apache.commons.logging.LogFactory;
import org.hibernate.LockMode;
import org.hibernate.Query;
import org.hibernate.criterion.Example;
import org.springframework.stereotype.Repository;

import com.fhr.shoestore.model.Region;

/**
 * A data access object (DAO) providing persistence and search support for
 * Region entities. Transaction control of the save(), update() and delete()
 * operations can directly support Spring container-managed transactions or they
 * can be augmented to handle user-managed Spring transactions. Each of these
 * methods provides additional information for how to configure it for the
 * desired type of transaction control.
 * 
 * @see com.fhr.shoestore.model.Region
 * @author MyEclipse Persistence Tools
 */
@Repository
public class RegionDAO extends BaseHibernateDAO {
	private static final Log log = LogFactory.getLog(RegionDAO.class);
	// property constants
	public static final String REGION_NAME = "regionName";
	public static final String REGION_ADDRESS = "regionAddress";

	public void save(Region transientInstance) {
		log.debug("saving Region instance");
		try {
			getSession().save(transientInstance);
			log.debug("save successful");
		} catch (RuntimeException re) {
			log.error("save failed", re);
			throw re;
		}
	}

	public void delete(Region persistentInstance) {
		log.debug("deleting Region instance");
		try {
			getSession().delete(persistentInstance);
			log.debug("delete successful");
		} catch (RuntimeException re) {
			log.error("delete failed", re);
			throw re;
		}
	}

	public Region findById(java.lang.Integer id) {
		log.debug("getting Region instance with id: " + id);
		try {
			Region instance = (Region) getSession().get("com.fhr.shoestore.model.Region", id);
			return instance;
		} catch (RuntimeException re) {
			log.error("get failed", re);
			throw re;
		}
	}

	public List findByExample(Region instance) {
		log.debug("finding Region instance by example");
		try {
			List results = getSession().createCriteria("com.fhr.shoestore.model.Region").add(Example.create(instance))
					.list();
			log.debug("find by example successful, result size: " + results.size());
			return results;
		} catch (RuntimeException re) {
			log.error("find by example failed", re);
			throw re;
		}
	}

	public List findByProperty(String propertyName, Object value) {
		log.debug("finding Region instance with property: " + propertyName + ", value: " + value);
		try {
			String queryString = "from Region as model where model." + propertyName + "= ?";
			Query queryObject = getSession().createQuery(queryString);
			queryObject.setParameter(0, value);
			return queryObject.list();
		} catch (RuntimeException re) {
			log.error("find by property name failed", re);
			throw re;
		}
	}

	public List findByRegionName(Object regionName) {
		return findByProperty(REGION_NAME, regionName);
	}

	public List findByRegionAddress(Object regionAddress) {
		return findByProperty(REGION_ADDRESS, regionAddress);
	}

	public List findAll() {
		log.debug("finding all Region instances");
		try {
			String queryString = "from Region";
			Query queryObject = getSession().createQuery(queryString);
			return queryObject.list();
		} catch (RuntimeException re) {
			log.error("find all failed", re);
			throw re;
		}
	}

	public Region merge(Region detachedInstance) {
		log.debug("merging Region instance");
		try {
			Region result = (Region) getSession().merge(detachedInstance);
			log.debug("merge successful");
			return result;
		} catch (RuntimeException re) {
			log.error("merge failed", re);
			throw re;
		}
	}

	public void attachDirty(Region instance) {
		log.debug("attaching dirty Region instance");
		try {
			getSession().saveOrUpdate(instance);
			log.debug("attach successful");
		} catch (RuntimeException re) {
			log.error("attach failed", re);
			throw re;
		}
	}

	public void attachClean(Region instance) {
		log.debug("attaching clean Region instance");
		try {
			getSession().lock(instance, LockMode.NONE);
			log.debug("attach successful");
		} catch (RuntimeException re) {
			log.error("attach failed", re);
			throw re;
		}
	}
}