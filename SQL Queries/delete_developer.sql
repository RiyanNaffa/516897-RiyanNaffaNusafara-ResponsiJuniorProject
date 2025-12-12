CREATE OR REPLACE FUNCTION public.delete_developer(
	d_id integer
) RETURNS void
LANGUAGE plpgsql
AS $function$
BEGIN
	DELETE FROM developer WHERE id = d_id;
END;
$function$