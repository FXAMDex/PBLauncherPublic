/*
 Navicat Premium Data Transfer

 Source Server         : ServerBeta
 Source Server Type    : PostgreSQL
 Source Server Version : 90525
 Source Host           : localhost:5432
 Source Catalog        : officialdb
 Source Schema         : public

 Target Server Type    : PostgreSQL
 Target Server Version : 90525
 File Encoding         : 65001

 Date: 22/03/2025 21:21:44
*/


-- ----------------------------
-- Table structure for get_banned_device
-- ----------------------------
DROP TABLE IF EXISTS "public"."get_banned_device";
CREATE TABLE "public"."get_banned_device" (
  "player_uid" varchar(255) COLLATE "pg_catalog"."default",
  "reason" varchar(255) COLLATE "pg_catalog"."default",
  "ip_address" varchar(255) COLLATE "pg_catalog"."default",
  "mac_address" varchar(255) COLLATE "pg_catalog"."default",
  "hwid" varchar(255) COLLATE "pg_catalog"."default",
  "date_end" date
)
;
