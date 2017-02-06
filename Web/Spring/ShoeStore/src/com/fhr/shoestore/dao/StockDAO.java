package com.fhr.shoestore.dao;

import java.sql.Timestamp;
import java.util.List;
import java.util.Set;
import org.apache.commons.logging.Log;
import org.apache.commons.logging.LogFactory;
import org.hibernate.LockMode;
import org.hibernate.Query;
import org.hibernate.criterion.Example;
import org.springframework.stereotype.Repository;

import com.fhr.shoestore.model.Stock;

/**
 * A data access object (DAO) providing persistence and search support for Stock
 * entities. Transaction control of the save(), update() and delete() operations
 * can directly support Spring container-managed transactions or they can be
 * augmented to handle user-managed Spring transactions. Each of these methods
 * provides additional information for how to configure it for the desired type
 * of transaction control.
 * 
 * @see com.fhr.shoestore.model.Stock
 * @author MyEclipse Persistence Tools
 */
@Repository
public class StockDAO extends BaseHibernateDAO {
	private static final Log log = LogFactory.getLog(StockDAO.class);
	// property constants
	public static final String STOCK_COUNT = "stockCount";

	public void save(Stock transientInstance) {
		log.debug("saving Stock instance");
		try {
			getSession().save(transientInstance);
			log.debug("save successful");
		} catch (RuntimeException re) {
			log.error("save failed", re);
			throw re;
		}
	}

	public void delete(Stock persistentInstance) {
		log.debug("deleting Stock instance");
		try {
			getSession().delete(persistentInstance);
			log.debug("delete successful");
		} catch (RuntimeException re) {
			log.error("delete failed", re);
			throw re;
		}
	}

	public Stock findById(java.lang.Long id) {
		log.debug("getting Stock instance with id: " + id);
		try {
			Stock instance = (Stock) getSession().get("com.fhr.shoestore.model.Stock", id);
			return instance;
		} catch (RuntimeException re) {
			log.error("get failed", re);
			throw re;
		}
	}

	public List findByExample(Stock instance) {
		log.debug("finding Stock instance by example");
		try {
			List results = getSession().createCriteria("com.fhr.shoestore.model.Stock").add(Example.create(instance))
					.list();
			log.debug("find by example successful, result size: " + results.size());
			return results;
		} catch (RuntimeException re) {
			log.error("find by example failed", re);
			throw re;
		}
	}

	public List findByProperty(String propertyName, Object value) {
		log.debug("finding Stock instance with property: " + propertyName + ", value: " + value);
		try {
			String queryString = "from Stock as model where model." + propertyName + "= ?";
			Query queryObject = getSession().createQuery(queryString);
			queryObject.setParameter(0, value);
			return queryObject.list();
		} catch (RuntimeException re) {
			log.error("find by property name failed", re);
			throw re;
		}
	}

	public List findByStockCount(Object stockCount) {
		return findByProperty(STOCK_COUNT, stockCount);
	}

	public List findAll() {
		log.debug("finding all Stock instances");
		try {
			String queryString = "from Stock";
			Query queryObject = getSession().createQuery(queryString);
			return queryObject.list();
		} catch (RuntimeException re) {
			log.error("find all failed", re);
			throw re;
		}
	}

	public Stock merge(Stock detachedInstance) {
		log.debug("merging Stock instance");
		try {
			Stock result = (Stock) getSession().merge(detachedInstance);
			log.debug("merge successful");
			return result;
		} catch (RuntimeException re) {
			log.error("merge failed", re);
			throw re;
		}
	}

	public void attachDirty(Stock instance) {
		log.debug("attaching dirty Stock instance");
		try {
			getSession().saveOrUpdate(instance);
			log.debug("attach successful");
		} catch (RuntimeException re) {
			log.error("attach failed", re);
			throw re;
		}
	}

	public void attachClean(Stock instance) {
		log.debug("attaching clean Stock instance");
		try {
			getSession().lock(instance, LockMode.NONE);
			log.debug("attach successful");
		} catch (RuntimeException re) {
			log.error("attach failed", re);
			throw re;
		}
	}
}