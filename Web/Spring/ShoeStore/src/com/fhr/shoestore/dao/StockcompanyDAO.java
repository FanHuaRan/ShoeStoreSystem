package com.fhr.shoestore.dao;

import java.util.List;
import java.util.Set;
import org.apache.commons.logging.Log;
import org.apache.commons.logging.LogFactory;
import org.hibernate.LockMode;
import org.hibernate.Query;
import org.hibernate.criterion.Example;
import org.springframework.stereotype.Repository;

import com.fhr.shoestore.model.Stockcompany;

/**
 * A data access object (DAO) providing persistence and search support for
 * Stockcompany entities. Transaction control of the save(), update() and
 * delete() operations can directly support Spring container-managed
 * transactions or they can be augmented to handle user-managed Spring
 * transactions. Each of these methods provides additional information for how
 * to configure it for the desired type of transaction control.
 * 
 * @see com.fhr.shoestore.model.Stockcompany
 * @author MyEclipse Persistence Tools
 */
@Repository
public class StockcompanyDAO extends BaseHibernateDAO {
	private static final Log log = LogFactory.getLog(StockcompanyDAO.class);
	// property constants
	public static final String STOCK_COMPANY_NAME = "stockCompanyName";

	public void save(Stockcompany transientInstance) {
		log.debug("saving Stockcompany instance");
		try {
			getSession().save(transientInstance);
			log.debug("save successful");
		} catch (RuntimeException re) {
			log.error("save failed", re);
			throw re;
		}
	}

	public void delete(Stockcompany persistentInstance) {
		log.debug("deleting Stockcompany instance");
		try {
			getSession().delete(persistentInstance);
			log.debug("delete successful");
		} catch (RuntimeException re) {
			log.error("delete failed", re);
			throw re;
		}
	}

	public Stockcompany findById(java.lang.Integer id) {
		log.debug("getting Stockcompany instance with id: " + id);
		try {
			Stockcompany instance = (Stockcompany) getSession().get("com.fhr.shoestore.model.Stockcompany", id);
			return instance;
		} catch (RuntimeException re) {
			log.error("get failed", re);
			throw re;
		}
	}

	public List findByExample(Stockcompany instance) {
		log.debug("finding Stockcompany instance by example");
		try {
			List results = getSession().createCriteria("com.fhr.shoestore.model.Stockcompany")
					.add(Example.create(instance)).list();
			log.debug("find by example successful, result size: " + results.size());
			return results;
		} catch (RuntimeException re) {
			log.error("find by example failed", re);
			throw re;
		}
	}

	public List findByProperty(String propertyName, Object value) {
		log.debug("finding Stockcompany instance with property: " + propertyName + ", value: " + value);
		try {
			String queryString = "from Stockcompany as model where model." + propertyName + "= ?";
			Query queryObject = getSession().createQuery(queryString);
			queryObject.setParameter(0, value);
			return queryObject.list();
		} catch (RuntimeException re) {
			log.error("find by property name failed", re);
			throw re;
		}
	}

	public List findByStockCompanyName(Object stockCompanyName) {
		return findByProperty(STOCK_COMPANY_NAME, stockCompanyName);
	}

	public List findAll() {
		log.debug("finding all Stockcompany instances");
		try {
			String queryString = "from Stockcompany";
			Query queryObject = getSession().createQuery(queryString);
			return queryObject.list();
		} catch (RuntimeException re) {
			log.error("find all failed", re);
			throw re;
		}
	}

	public Stockcompany merge(Stockcompany detachedInstance) {
		log.debug("merging Stockcompany instance");
		try {
			Stockcompany result = (Stockcompany) getSession().merge(detachedInstance);
			log.debug("merge successful");
			return result;
		} catch (RuntimeException re) {
			log.error("merge failed", re);
			throw re;
		}
	}

	public void attachDirty(Stockcompany instance) {
		log.debug("attaching dirty Stockcompany instance");
		try {
			getSession().saveOrUpdate(instance);
			log.debug("attach successful");
		} catch (RuntimeException re) {
			log.error("attach failed", re);
			throw re;
		}
	}

	public void attachClean(Stockcompany instance) {
		log.debug("attaching clean Stockcompany instance");
		try {
			getSession().lock(instance, LockMode.NONE);
			log.debug("attach successful");
		} catch (RuntimeException re) {
			log.error("attach failed", re);
			throw re;
		}
	}
}