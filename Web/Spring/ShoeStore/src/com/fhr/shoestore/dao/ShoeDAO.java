package com.fhr.shoestore.dao;

import java.util.List;
import java.util.Set;
import org.apache.commons.logging.Log;
import org.apache.commons.logging.LogFactory;
import org.hibernate.LockMode;
import org.hibernate.Query;
import org.hibernate.criterion.Example;
import org.springframework.stereotype.Repository;

import com.fhr.shoestore.model.Shoe;

/**
 * A data access object (DAO) providing persistence and search support for Shoe
 * entities. Transaction control of the save(), update() and delete() operations
 * can directly support Spring container-managed transactions or they can be
 * augmented to handle user-managed Spring transactions. Each of these methods
 * provides additional information for how to configure it for the desired type
 * of transaction control.
 * 
 * @see com.fhr.shoestore.model.Shoe
 * @author MyEclipse Persistence Tools
 */
@Repository
public class ShoeDAO extends BaseHibernateDAO {
	private static final Log log = LogFactory.getLog(ShoeDAO.class);
	// property constants
	public static final String THING_ID = "thingId";
	public static final String COLOR = "color";
	public static final String SIZE = "size";
	public static final String PRICE = "price";
	public static final String IS_SELL = "isSell";
	public static final String SELL_PRICE = "sellPrice";

	public void save(Shoe transientInstance) {
		log.debug("saving Shoe instance");
		try {
			getSession().save(transientInstance);
			log.debug("save successful");
		} catch (RuntimeException re) {
			log.error("save failed", re);
			throw re;
		}
	}

	public void delete(Shoe persistentInstance) {
		log.debug("deleting Shoe instance");
		try {
			getSession().delete(persistentInstance);
			log.debug("delete successful");
		} catch (RuntimeException re) {
			log.error("delete failed", re);
			throw re;
		}
	}

	public Shoe findById(java.lang.Long id) {
		log.debug("getting Shoe instance with id: " + id);
		try {
			Shoe instance = (Shoe) getSession().get("com.fhr.shoestore.model.Shoe", id);
			return instance;
		} catch (RuntimeException re) {
			log.error("get failed", re);
			throw re;
		}
	}

	public List findByExample(Shoe instance) {
		log.debug("finding Shoe instance by example");
		try {
			List results = getSession().createCriteria("com.fhr.shoestore.model.Shoe").add(Example.create(instance))
					.list();
			log.debug("find by example successful, result size: " + results.size());
			return results;
		} catch (RuntimeException re) {
			log.error("find by example failed", re);
			throw re;
		}
	}

	public List findByProperty(String propertyName, Object value) {
		log.debug("finding Shoe instance with property: " + propertyName + ", value: " + value);
		try {
			String queryString = "from Shoe as model where model." + propertyName + "= ?";
			Query queryObject = getSession().createQuery(queryString);
			queryObject.setParameter(0, value);
			return queryObject.list();
		} catch (RuntimeException re) {
			log.error("find by property name failed", re);
			throw re;
		}
	}

	public List findByThingId(Object thingId) {
		return findByProperty(THING_ID, thingId);
	}

	public List findByColor(Object color) {
		return findByProperty(COLOR, color);
	}

	public List findBySize(Object size) {
		return findByProperty(SIZE, size);
	}

	public List findByPrice(Object price) {
		return findByProperty(PRICE, price);
	}

	public List findByIsSell(Object isSell) {
		return findByProperty(IS_SELL, isSell);
	}

	public List findBySellPrice(Object sellPrice) {
		return findByProperty(SELL_PRICE, sellPrice);
	}

	public List findAll() {
		log.debug("finding all Shoe instances");
		try {
			String queryString = "from Shoe";
			Query queryObject = getSession().createQuery(queryString);
			return queryObject.list();
		} catch (RuntimeException re) {
			log.error("find all failed", re);
			throw re;
		}
	}

	public Shoe merge(Shoe detachedInstance) {
		log.debug("merging Shoe instance");
		try {
			Shoe result = (Shoe) getSession().merge(detachedInstance);
			log.debug("merge successful");
			return result;
		} catch (RuntimeException re) {
			log.error("merge failed", re);
			throw re;
		}
	}

	public void attachDirty(Shoe instance) {
		log.debug("attaching dirty Shoe instance");
		try {
			getSession().saveOrUpdate(instance);
			log.debug("attach successful");
		} catch (RuntimeException re) {
			log.error("attach failed", re);
			throw re;
		}
	}

	public void attachClean(Shoe instance) {
		log.debug("attaching clean Shoe instance");
		try {
			getSession().lock(instance, LockMode.NONE);
			log.debug("attach successful");
		} catch (RuntimeException re) {
			log.error("attach failed", re);
			throw re;
		}
	}
}