
WITH user_follows AS (
  SELECT 
    u.id,
    u.age,
    CASE 
      WHEN u.age >= 10 AND u.age <= 19 THEN "10代"
      WHEN u.age >= 20 AND u.age <= 29 THEN "20代"
      WHEN u.age >= 30 AND u.age <= 39 THEN "30代"
      ELSE NULL
    END AS age_group,
    COUNT(f.followee_id) AS follow_count
  FROM users u
  LEFT OUTER JOIN follows f ON u.id = f.follower_id
  GROUP BY u.id, u.age, age_group
)
SELECT
  age_group,
  AVG(follow_count) AS avg_follow_count
FROM user_follows
GROUP BY age_group;
