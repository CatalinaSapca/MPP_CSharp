﻿using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persistance
{/**
    * CRUD operations repository interface
    * @param <ID> - type E must have an attribute of type ID
    * @param <E> -  type of entities saved in repository
    */
    public interface Repository<ID, E> where E : Entity<ID>
    {

        /**
        * @param id -the id of the entity to be returned
        *           id must not be null
        * @return the entity with the specified id
        * or null - if there is no entity with the given id
        * @throws IllegalArgumentException if id is null.
        */
        E FindOne(ID id);

        /**
        * @return all entities
        */
        IEnumerable<E> FindAll();

        /**
        * @param entity entity must be not null
        * @return null- if the given entity is saved
        * otherwise returns the entity (id already exists)
        * @throws ValidationException      if the entity is not valid
        * @throws IllegalArgumentException if the given entity is null.     *
        */
        E Save(E entity);

        /**
        * removes the entity with the specified id
        *
        * @param id id must be not null
        * @return the removed entity or null if there is no entity with the given id
        * @throws IllegalArgumentException if the given id is null.
        */
        E Delete(ID id);

        /**
        * @param entity entity must not be null
        * @return null - if the entity is updated,
        * otherwise  returns the entity  - (e.g id does not exist).
        * @throws IllegalArgumentException if the given entity is null.
        * @throws ValidationException      if the entity is not valid.
        */
        E Update(E entity);
    }
}
