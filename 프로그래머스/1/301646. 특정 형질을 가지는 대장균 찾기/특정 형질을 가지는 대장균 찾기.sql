-- 코드를 작성해주세요

select Count(ID) AS COUNT from ECOLI_DATA 
WHERE (GENOTYPE & 2 = 0) AND(GENOTYPE & 1 > 0 OR GENOTYPE & 4 > 0);