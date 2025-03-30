/*
 Navicat Premium Data Transfer

 Source Server         : Server Utama
 Source Server Type    : PostgreSQL
 Source Server Version : 90525
 Source Host           : 152.42.173.36:5432
 Source Catalog        : officialdb
 Source Schema         : public

 Target Server Type    : PostgreSQL
 Target Server Version : 90525
 File Encoding         : 65001

 Date: 29/03/2025 09:40:16
*/


-- ----------------------------
-- Table structure for info_icafe_data
-- ----------------------------
DROP TABLE IF EXISTS "public"."info_icafe_data";
CREATE TABLE "public"."info_icafe_data" (
  "ip_icafe" varchar(255) COLLATE "pg_catalog"."default",
  "date_start" date,
  "date_end" date,
  "type_icafe" varchar(255) COLLATE "pg_catalog"."default"
)
;
