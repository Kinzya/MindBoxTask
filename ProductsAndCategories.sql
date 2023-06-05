SELECT pr."Name", cat."Name"
	FROM "Product" pr
	LEFT JOIN "Product_Category" pc ON pr."Id" = pc."ProductID"
	LEFT JOIN "Category" cat ON pc."CategoryID" = cat."Id"


-- Все делал в pgAdmin, отличаться должен только синтаксис, и то чуть-чуть... вроде 
--CREATE TABLE "Category"
--(
--    "Id" bigint NOT NULL,
--    "Name" character varying COLLATE pg_catalog."default" NOT NULL,
--    CONSTRAINT "Category_pkey" PRIMARY KEY ("Id")
--)

--CREATE TABLE "Product"
--(
--    "Id" bigint NOT NULL,
--    "Name" character varying COLLATE pg_catalog."default" NOT NULL,
--    CONSTRAINT "Product_pkey" PRIMARY KEY ("Id")
--)

--CREATE TABLE "Product_Category"
--(
--    id bigint NOT NULL,
--    "ProductID" bigint NOT NULL,
--    "CategoryID" bigint NOT NULL,
--    CONSTRAINT "Product_Category_pkey" PRIMARY KEY (id),
--    CONSTRAINT "CategoryID" FOREIGN KEY ("CategoryID")
--        REFERENCES public."Category" ("Id") MATCH SIMPLE
--        ON UPDATE NO ACTION
--        ON DELETE NO ACTION
--        NOT VALID,
--    CONSTRAINT "ProductID" FOREIGN KEY ("ProductID")
--        REFERENCES public."Product" ("Id") MATCH SIMPLE
--        ON UPDATE NO ACTION
--        ON DELETE NO ACTION
--        NOT VALID
--)