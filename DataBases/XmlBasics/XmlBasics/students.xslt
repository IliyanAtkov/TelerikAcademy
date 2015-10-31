<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0"
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <body>
        <h1>Some students</h1>
        <table bgcolor="#E0E0E0" cellspacing="1">
          <tr bgcolor="#EEEEEE">
            <td>
              <b>name</b>
            </td>
            <td>
              <b>sex</b>
            </td>
            <td>
              <b>birthDate</b>
            </td>
            <td>
              <b>phone</b>
            </td>
            <td>
              <b>email</b>
            </td>
            <td>
              <b>course</b>
            </td>
            <td>
              <b>specialty</b>
            </td>
            <td>
              <b>facultyNumber</b>
            </td>
            <td>
              <b>name</b>
            </td>
            <td>
              <b>tutor</b>
            </td>
            <td>
              <b>score</b>
            </td>
               <td>
              <b>name</b>
            </td>
            <td>
              <b>tutor</b>
            </td>
            <td>
              <b>score</b>
            </td>
          </tr>
          <xsl:for-each select="/students/student">
            <tr bgcolor="white">
              <td>
                <xsl:value-of select="name"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="sex"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="birthDate"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="phone"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="email"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="course"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="specialty"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="facultyNumber"></xsl:value-of>
              </td>
              <xsl:for-each select="exams/exam">
                <td>
                  <xsl:value-of select="name"></xsl:value-of>
                </td>
                <td>
                  <xsl:value-of select="tutor"></xsl:value-of>
                </td>
                <td>
                  <xsl:value-of select="score"></xsl:value-of>
                </td>
              </xsl:for-each>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>