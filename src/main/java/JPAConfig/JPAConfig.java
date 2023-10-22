package JPAConfig;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;

public class JPAConfig {
	private static EntityManagerFactory factory;
	
	static public EntityManager getEntityManager() 
	{
		if(factory == null || !factory.isOpen()) {
			factory = Persistence.createEntityManagerFactory("Web_ProductCategory");
		}
		return factory.createEntityManager();
	}
	
	
	static public void shutDown() {
		if(factory != null && factory.isOpen()) {
			factory.close();
		}
		factory = null;
	}
}

