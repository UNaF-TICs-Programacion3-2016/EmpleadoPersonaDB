--------------------------------------------------------
-- Archivo creado  - lunes-noviembre-21-2016   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table PERSONA
--------------------------------------------------------

  CREATE TABLE "PERSONA" 
   (	"ID_PERSONA" NUMBER(10,0)
	, 
	"APELLIDOYNOMBRE" VARCHAR2(250 BYTE)
	, 
	"SEXO" NUMBER(1,0)
	, 
	"DNI" VARCHAR2(8 BYTE)
	, 
	"CUIL" VARCHAR2(11 BYTE)
	, 
	"FECHANACIMIENTO" DATE,
	 
	"ESTADOCIVIL" NUMBER(1,0)
) ;

  COMMENT ON COLUMN ."PERSONA"."SEXO" IS '0:Femenino; 1:Masculino';
   
  COMMENT ON COLUMN "PERSONA"."ESTADOCIVIL" IS '0:Soltera/o; 1:Casado/a; 2:Viudo/a; 3:Divorciado';

--------------------------------------------------------
--  DDL for Index IDX_IDPERSONA
--------------------------------------------------------

  CREATE UNIQUE INDEX "IDX_IDPERSONA" ON "PERSONA" ("ID_PERSONA") ;

--------------------------------------------------------
--  DDL for Index IDX_PERSONA_APELLIDOYNOMBRE
--------------------------------------------------------

  CREATE INDEX "IDX_PERSONA_APELLIDOYNOMBRE" ON "PERSONA" ("APELLIDOYNOMBRE");

--------------------------------------------------------
--  Constraints for Table PERSONA
--------------------------------------------------------

  ALTER TABLE "PERSONA" ADD CONSTRAINT "PERSONA_PK" PRIMARY KEY ("ID_PERSONA")
;

  ALTER TABLE "PERSONA" MODIFY ("DNI" NOT NULL ENABLE);
  
  ALTER TABLE "PERSONA" MODIFY ("SEXO" NOT NULL ENABLE);
  
  ALTER TABLE "PERSONA" MODIFY ("APELLIDOYNOMBRE" NOT NULL ENABLE);
  
  ALTER TABLE "PERSONA" MODIFY ("ID_PERSONA" NOT NULL ENABLE);

--------------------------------------------------------
--  DDL for Trigger PK_PERSONA
--------------------------------------------------------

   CREATE SEQUENCE  "S_PERSONA"  MINVALUE 1 MAXVALUE 9999999999 INCREMENT BY 1 START WITH 1 NOCACHE  NOORDER  NOCYCLE ;

  CREATE OR REPLACE TRIGGER "PK_PERSONA" 
   
  before insert on "PERSONA" 
   for each row 
begin  
  
      select S_PERSONA.nextval into :NEW.ID_PERSONA from dual; 

  end;
/
ALTER TRIGGER "PK_PERSONA" ENABLE;
