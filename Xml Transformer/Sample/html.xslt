<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="2.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="html" version="5" html-version="5.0" encoding="utf-8" indent="yes" doctype-public="" doctype-system=""/>

	<xsl:template match="/">
		
		<!--
		<xsl:text disable-output-escaping="yes">&lt;!DOCTYPE html&gt;</xsl:text>
		
		<![CDATA[
			<![DOCTYPE html>
		]]>
		-->
		<html>
			<head>
				<style>
				* {
					font-family: 'Baskerville Old Face', Calibri, Arial;
				}
				table {
					border-collapse: collapse;
				}
				th, td {
					border: solid 1px #ccc;
					vertical-align: top;
					padding: 5px;
				}
				th {
					background: #39f;
				}
				img {
					width: 256px;
					height: 256	px;
				}
				h4 {
					color: Green;
					margin: 0;
				}
				label {
					font-weight: bold;
				}
				p {
					margin: 5px;
				}
				span.seq {
					color: #bbb;
					padding-right: 3px;
				}
				span.remark {
					padding-left: 3px;
					color: #9cf;
				}
				tr.first-row:first-child {
					border-top: inherit;
				}
				tr.first-row {
					border-top: double 4px #ccc;
				}
				</style>
			</head>
			<body>
				<table>
				<thead>
					<tr>
						<th>CD</th>
						<th>Track List</th>
					</tr>
				</thead>
				<tbody>
					<xsl:for-each select="/Catalog/CD">
						<xsl:variable name="trackCount" select="count(TrackList/Track)"/>
						<xsl:variable name="cover" select="Cover"/>
						<tr class="first-row">
							<td rowspan="{$trackCount}">
								<h4><xsl:value-of select="upper-case(Title)"/></h4>
								<p>
									<div><label>Artist: </label><span><xsl:value-of select="Artist"/></span></div>
									<div><label>Country: </label><span><xsl:value-of select="Country"/></span></div>
									<div><label>Publisher: </label><span><xsl:value-of select="Publisher"/></span></div>
									<div><label>Year: </label><span><xsl:value-of select="Year"/></span></div>
								</p>
								<img src="{$cover}"/>
							</td>
							<td><span class="seq">1.</span><span><xsl:value-of select="TrackList/Track[1]"/></span><span class="remark">(<xsl:value-of select="TrackList/Track[1]/@length"/>, <xsl:value-of select="TrackList/Track[1]/@composer"/>)</span></td>
						</tr>
						
						<xsl:for-each select="./TrackList/Track">
							<xsl:if test="position() != 1">
								<tr>
									<td><span class="seq"><xsl:value-of select="position()"/>.</span><span><xsl:value-of select="."/></span><span class="remark">(<xsl:value-of select="@length"/>, <xsl:value-of select="@composer"/>)</span></td>
								</tr>
							</xsl:if>
						</xsl:for-each>
					</xsl:for-each>
				</tbody>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>