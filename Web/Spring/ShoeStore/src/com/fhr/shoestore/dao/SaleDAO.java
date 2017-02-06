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

import com.fhr.shoestore.model.Sale;

/**
 * A data access object (DAO) providing persistence and search support for Sale
 * entities. Transaction control of the save(), update() and delete() operations
 * can directly support Spring container-managed transactions or they can be
 * augmented to handle user-managed Spring transactions. Each of these methods
 * provides additional information for how to configure it for the desired type
 * of transaction control.
 * 
 * @see com.fhr.shoestore.model.Sale
 * @author MyEclipse Persistence Tools
 */
@Repository
public class SaleDAO extends BaseHibernateDAO {
	private static final Log log = LogFactory.getLog(SaleDAO.class);
	// property constants
	public static final String PHONE = "phone";
	public static final String TOTAL_PRICE = "totalPrice";

	public void save(Sale transientInstance) {
		log.debug("saving Sale instance");
		try {
			getSession().save(transientInstance);
			log.debug("save successful");
		} catch (RuntimeException re) {
			log.error("save failed", re);
			throw re;
		}
	}

	public void delete(Sale persistentInstance) {
		log.debug("deleting Sale instance");
		try {
			getSession().delete(persistentInstance);
			log.debug("delete successful");
		} catch (RuntimeException re) {
			log.error("delete failed", re);
			throw re;
		}
	}

	public Sale findById(java.lang.Long id) {
		log.debug("getting Sale instance with id: " + id);
		try {
			Sale instance = (Sale) getSession().get("com.fhr.shoestore.model.Sale", id);
			return instance;
		} catch (RuntimeException re) {
			log.error("get failed", re);
			throw re;
		}
	}

	public List findByExample(Sale instance) {
		log.debug("finding Sale instance by example");
		try {
			List results = getSession().createCriteria("com.fhr.shoestore.model.Sale").add(Example.create(instance))
					.list();
			log.debug("find by example successful, result size: " + results.size());
			return results;
		} catch (RuntimeException re) {
			log.error("find by example failed", re);
			throw re;
		}
	}

	public List findByProperty(String propertyName, Object value) {
		log.debug("finding Sale instance with property: " + propertyName + ", value: " + value);
		try {
			String queryString = "from Sale as model where model." + propertyName + "= ?";
			Query queryObject = getSession().createQuery(queryString);
			queryObject.setParameter(0, value);
			return queryObject.list();
		} catch (RuntimeException re) {
			log.error("find by property name failed", re);
			throw re;
		}
	}

	public List findByPhone(Object phone) {
		return findByProperty(PHONE, phone);
	}

	public List findByTotalPrice(Object totalPrice) {
		return findByProperty(TOTAL_PRICE, totalPrice);
	}

	public List findAll() {
		log.debug("finding all Sale instances");
		try {
			String queryString = "from Sale";
			Query queryObject = getSession().createQuery(queryString);
			return queryObject.list();
		} catch (RuntimeException re) {
			log.error("find all failed", re);
			throw re;
		}
	}

	public Sale merge(Sale detachedInstance) {
		log.debug("merging Sale instance");
		try {
			Sale result = (Sale) getSession().merge(detachedInstance);
			log.debug("merge successful");
			return result;
		} catch (RuntimeException re) {
			log.error("merge failed", re);
			throw re;
		}
	}

	public void attachDirty(Sale instance) {
		log.debug("attaching dirty Sale instance");
		try {
			getSession().saveOrUpdate(instance);
			log.debug("attach successful");
		} catch (RuntimeException re) {
			log.error("attach failed", re);
			throw re;
		}
	}

	public void attachClean(Sale instance) {
		log.debug("attaching clean Sale instance");
		try {
			getSession().lock(instance, LockMode.NONE);
			log.debug("attach successful");
		} catch (RuntimeException re) {
			log.error("attach failed", re);
			throw re;
		}
	}
}