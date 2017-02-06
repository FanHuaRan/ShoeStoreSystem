package com.fhr.shoestore.dao;

import java.util.List;
import java.util.Set;
import org.apache.commons.logging.Log;
import org.apache.commons.logging.LogFactory;
import org.hibernate.LockMode;
import org.hibernate.Query;
import org.hibernate.criterion.Example;
import org.springframework.stereotype.Repository;

import com.fhr.shoestore.model.Season;

/**
 * A data access object (DAO) providing persistence and search support for
 * Season entities. Transaction control of the save(), update() and delete()
 * operations can directly support Spring container-managed transactions or they
 * can be augmented to handle user-managed Spring transactions. Each of these
 * methods provides additional information for how to configure it for the
 * desired type of transaction control.
 * 
 * @see com.fhr.shoestore.model.Season
 * @author MyEclipse Persistence Tools
 */
@Repository
public class SeasonDAO extends BaseHibernateDAO {
	private static final Log log = LogFactory.getLog(SeasonDAO.class);
	// property constants
	public static final String SEASON_NAME = "seasonName";

	public void save(Season transientInstance) {
		log.debug("saving Season instance");
		try {
			getSession().save(transientInstance);
			log.debug("save successful");
		} catch (RuntimeException re) {
			log.error("save failed", re);
			throw re;
		}
	}

	public void delete(Season persistentInstance) {
		log.debug("deleting Season instance");
		try {
			getSession().delete(persistentInstance);
			log.debug("delete successful");
		} catch (RuntimeException re) {
			log.error("delete failed", re);
			throw re;
		}
	}

	public Season findById(java.lang.Integer id) {
		log.debug("getting Season instance with id: " + id);
		try {
			Season instance = (Season) getSession().get("com.fhr.shoestore.model.Season", id);
			return instance;
		} catch (RuntimeException re) {
			log.error("get failed", re);
			throw re;
		}
	}

	public List findByExample(Season instance) {
		log.debug("finding Season instance by example");
		try {
			List results = getSession().createCriteria("com.fhr.shoestore.model.Season").add(Example.create(instance))
					.list();
			log.debug("find by example successful, result size: " + results.size());
			return results;
		} catch (RuntimeException re) {
			log.error("find by example failed", re);
			throw re;
		}
	}

	public List findByProperty(String propertyName, Object value) {
		log.debug("finding Season instance with property: " + propertyName + ", value: " + value);
		try {
			String queryString = "from Season as model where model." + propertyName + "= ?";
			Query queryObject = getSession().createQuery(queryString);
			queryObject.setParameter(0, value);
			return queryObject.list();
		} catch (RuntimeException re) {
			log.error("find by property name failed", re);
			throw re;
		}
	}

	public List findBySeasonName(Object seasonName) {
		return findByProperty(SEASON_NAME, seasonName);
	}

	public List findAll() {
		log.debug("finding all Season instances");
		try {
			String queryString = "from Season";
			Query queryObject = getSession().createQuery(queryString);
			return queryObject.list();
		} catch (RuntimeException re) {
			log.error("find all failed", re);
			throw re;
		}
	}

	public Season merge(Season detachedInstance) {
		log.debug("merging Season instance");
		try {
			Season result = (Season) getSession().merge(detachedInstance);
			log.debug("merge successful");
			return result;
		} catch (RuntimeException re) {
			log.error("merge failed", re);
			throw re;
		}
	}

	public void attachDirty(Season instance) {
		log.debug("attaching dirty Season instance");
		try {
			getSession().saveOrUpdate(instance);
			log.debug("attach successful");
		} catch (RuntimeException re) {
			log.error("attach failed", re);
			throw re;
		}
	}

	public void attachClean(Season instance) {
		log.debug("attaching clean Season instance");
		try {
			getSession().lock(instance, LockMode.NONE);
			log.debug("attach successful");
		} catch (RuntimeException re) {
			log.error("attach failed", re);
			throw re;
		}
	}
}