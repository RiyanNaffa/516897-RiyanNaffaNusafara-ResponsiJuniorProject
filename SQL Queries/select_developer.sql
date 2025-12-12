CREATE OR REPLACE FUNCTION public.select_developer() RETURNS TABLE(
id integer,
nama character varying,
status_kontrtak character varying,
fitur_selesai integer,
jumlah_bug integer,
nama_proyek character varying
) LANGUAGE plpgsql
AS $function$
BEGIN
	RETURN QUERY
	SELECT
		d.id,
		d.nama,
		d.status_kontrak,
		d.fitur_selesai,
		d.jumlah_bug,
		p.nama AS nama_proyek
	FROM developer d
	LEFT JOIN proyek p ON d.proyek_id = p.id
	ORDER BY k.id;
END;
$function$