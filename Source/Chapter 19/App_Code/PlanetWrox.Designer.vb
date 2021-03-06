﻿
'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Data.EntityClient
Imports System.ComponentModel
Imports System.Xml.Serialization
Imports System.Runtime.Serialization

<Assembly: EdmSchemaAttribute("d0fc2f69-8a64-4881-b2b3-f71fb36f3656")>
#Region "EDM Relationship Metadata"
<Assembly: EdmRelationshipAttribute("PlanetWroxModel", "FK_Review_Genre", "Genre", System.Data.Metadata.Edm.RelationshipMultiplicity.One, GetType(PlanetWroxModel.Genre), "Review", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, GetType(PlanetWroxModel.Review), True)>
<Assembly: EdmRelationshipAttribute("PlanetWroxModel", "FK_Picture_PhotoAlbum", "PhotoAlbum", System.Data.Metadata.Edm.RelationshipMultiplicity.One, GetType(PlanetWroxModel.PhotoAlbum), "Picture", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, GetType(PlanetWroxModel.Picture), True)>

#End Region
Namespace PlanetWroxModel
    
    #Region "Contexts"
    
    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    Public Partial Class PlanetWroxEntities
        Inherits ObjectContext
    
        #Region "Constructors"
    
        ''' <summary>
        ''' Initializes a new PlanetWroxEntities object using the connection string found in the 'PlanetWroxEntities' section of the application configuration file.
        ''' </summary>
        Public Sub New()
            MyBase.New("name=PlanetWroxEntities", "PlanetWroxEntities")
        MyBase.ContextOptions.LazyLoadingEnabled = true
            OnContextCreated()
        End Sub
    
        ''' <summary>
        ''' Initialize a new PlanetWroxEntities object.
        ''' </summary>
        Public Sub New(ByVal connectionString As String)
            MyBase.New(connectionString, "PlanetWroxEntities")
        MyBase.ContextOptions.LazyLoadingEnabled = true
            OnContextCreated()
        End Sub
    
        ''' <summary>
        ''' Initialize a new PlanetWroxEntities object.
        ''' </summary>
        Public Sub New(ByVal connection As EntityConnection)
            MyBase.New(connection, "PlanetWroxEntities")
        MyBase.ContextOptions.LazyLoadingEnabled = true
            OnContextCreated()
        End Sub
    
        #End Region
    
        #Region "Partial Methods"
    
        Partial Private Sub OnContextCreated()
        End Sub
    
        #End Region
    
        #Region "ObjectSet Properties"
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        Public ReadOnly Property Genres() As ObjectSet(Of Genre)
            Get
                If (_Genres Is Nothing) Then
                    _Genres = MyBase.CreateObjectSet(Of Genre)("Genres")
                End If
                Return _Genres
            End Get
        End Property
    
        Private _Genres As ObjectSet(Of Genre)
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        Public ReadOnly Property Reviews() As ObjectSet(Of Review)
            Get
                If (_Reviews Is Nothing) Then
                    _Reviews = MyBase.CreateObjectSet(Of Review)("Reviews")
                End If
                Return _Reviews
            End Get
        End Property
    
        Private _Reviews As ObjectSet(Of Review)
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        Public ReadOnly Property PhotoAlbums() As ObjectSet(Of PhotoAlbum)
            Get
                If (_PhotoAlbums Is Nothing) Then
                    _PhotoAlbums = MyBase.CreateObjectSet(Of PhotoAlbum)("PhotoAlbums")
                End If
                Return _PhotoAlbums
            End Get
        End Property
    
        Private _PhotoAlbums As ObjectSet(Of PhotoAlbum)
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        Public ReadOnly Property Pictures() As ObjectSet(Of Picture)
            Get
                If (_Pictures Is Nothing) Then
                    _Pictures = MyBase.CreateObjectSet(Of Picture)("Pictures")
                End If
                Return _Pictures
            End Get
        End Property
    
        Private _Pictures As ObjectSet(Of Picture)

        #End Region
        #Region "AddTo Methods"
    
        ''' <summary>
        ''' Deprecated Method for adding a new object to the Genres EntitySet. Consider using the .Add method of the associated ObjectSet(Of T) property instead.
        ''' </summary>
        Public Sub AddToGenres(ByVal genre As Genre)
            MyBase.AddObject("Genres", genre)
        End Sub
    
        ''' <summary>
        ''' Deprecated Method for adding a new object to the Reviews EntitySet. Consider using the .Add method of the associated ObjectSet(Of T) property instead.
        ''' </summary>
        Public Sub AddToReviews(ByVal review As Review)
            MyBase.AddObject("Reviews", review)
        End Sub
    
        ''' <summary>
        ''' Deprecated Method for adding a new object to the PhotoAlbums EntitySet. Consider using the .Add method of the associated ObjectSet(Of T) property instead.
        ''' </summary>
        Public Sub AddToPhotoAlbums(ByVal photoAlbum As PhotoAlbum)
            MyBase.AddObject("PhotoAlbums", photoAlbum)
        End Sub
    
        ''' <summary>
        ''' Deprecated Method for adding a new object to the Pictures EntitySet. Consider using the .Add method of the associated ObjectSet(Of T) property instead.
        ''' </summary>
        Public Sub AddToPictures(ByVal picture As Picture)
            MyBase.AddObject("Pictures", picture)
        End Sub

        #End Region
    End Class

    #End Region
    #Region "Entities"
    
    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmEntityTypeAttribute(NamespaceName:="PlanetWroxModel", Name:="Genre")>
    <Serializable()>
    <DataContractAttribute(IsReference:=True)>
    Public Partial Class Genre
        Inherits EntityObject
        #Region "Factory Method"
    
        ''' <summary>
        ''' Create a new Genre object.
        ''' </summary>
        ''' <param name="id">Initial value of the Id property.</param>
        ''' <param name="name">Initial value of the Name property.</param>
        ''' <param name="sortOrder">Initial value of the SortOrder property.</param>
        Public Shared Function CreateGenre(id As Global.System.Int32, name As Global.System.String, sortOrder As Global.System.Int32) As Genre
            Dim genre as Genre = New Genre
            genre.Id = id
            genre.Name = name
            genre.SortOrder = sortOrder
            Return genre
        End Function

        #End Region
        #Region "Primitive Properties"
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property Id() As Global.System.Int32
            Get
                Return _Id
            End Get
            Set
                If (_Id <> Value) Then
                    OnIdChanging(value)
                    ReportPropertyChanging("Id")
                    _Id = StructuralObject.SetValidValue(value)
                    ReportPropertyChanged("Id")
                    OnIdChanged()
                End If
            End Set
        End Property
    
        Private _Id As Global.System.Int32
        Private Partial Sub OnIdChanging(value As Global.System.Int32)
        End Sub
    
        Private Partial Sub OnIdChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property Name() As Global.System.String
            Get
                Return _Name
            End Get
            Set
                OnNameChanging(value)
                ReportPropertyChanging("Name")
                _Name = StructuralObject.SetValidValue(value, false)
                ReportPropertyChanged("Name")
                OnNameChanged()
            End Set
        End Property
    
        Private _Name As Global.System.String
        Private Partial Sub OnNameChanging(value As Global.System.String)
        End Sub
    
        Private Partial Sub OnNameChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property SortOrder() As Global.System.Int32
            Get
                Return _SortOrder
            End Get
            Set
                OnSortOrderChanging(value)
                ReportPropertyChanging("SortOrder")
                _SortOrder = StructuralObject.SetValidValue(value)
                ReportPropertyChanged("SortOrder")
                OnSortOrderChanged()
            End Set
        End Property
    
        Private _SortOrder As Global.System.Int32
        Private Partial Sub OnSortOrderChanging(value As Global.System.Int32)
        End Sub
    
        Private Partial Sub OnSortOrderChanged()
        End Sub

        #End Region
        #Region "Navigation Properties"
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <XmlIgnoreAttribute()>
        <SoapIgnoreAttribute()>
        <DataMemberAttribute()>
        <EdmRelationshipNavigationPropertyAttribute("PlanetWroxModel", "FK_Review_Genre", "Review")>
         Public Property Reviews() As EntityCollection(Of Review)
            Get
                Return CType(Me,IEntityWithRelationships).RelationshipManager.GetRelatedCollection(Of Review)("PlanetWroxModel.FK_Review_Genre", "Review")
            End Get
            Set
                If (Not value Is Nothing)
                    CType(Me, IEntityWithRelationships).RelationshipManager.InitializeRelatedCollection(Of Review)("PlanetWroxModel.FK_Review_Genre", "Review", value)
                End If
            End Set
        End Property

        #End Region
    End Class
    
    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmEntityTypeAttribute(NamespaceName:="PlanetWroxModel", Name:="PhotoAlbum")>
    <Serializable()>
    <DataContractAttribute(IsReference:=True)>
    Public Partial Class PhotoAlbum
        Inherits EntityObject
        #Region "Factory Method"
    
        ''' <summary>
        ''' Create a new PhotoAlbum object.
        ''' </summary>
        ''' <param name="id">Initial value of the Id property.</param>
        ''' <param name="name">Initial value of the Name property.</param>
        Public Shared Function CreatePhotoAlbum(id As Global.System.Int32, name As Global.System.String) As PhotoAlbum
            Dim photoAlbum as PhotoAlbum = New PhotoAlbum
            photoAlbum.Id = id
            photoAlbum.Name = name
            Return photoAlbum
        End Function

        #End Region
        #Region "Primitive Properties"
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property Id() As Global.System.Int32
            Get
                Return _Id
            End Get
            Set
                If (_Id <> Value) Then
                    OnIdChanging(value)
                    ReportPropertyChanging("Id")
                    _Id = StructuralObject.SetValidValue(value)
                    ReportPropertyChanged("Id")
                    OnIdChanged()
                End If
            End Set
        End Property
    
        Private _Id As Global.System.Int32
        Private Partial Sub OnIdChanging(value As Global.System.Int32)
        End Sub
    
        Private Partial Sub OnIdChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property Name() As Global.System.String
            Get
                Return _Name
            End Get
            Set
                OnNameChanging(value)
                ReportPropertyChanging("Name")
                _Name = StructuralObject.SetValidValue(value, false)
                ReportPropertyChanged("Name")
                OnNameChanged()
            End Set
        End Property
    
        Private _Name As Global.System.String
        Private Partial Sub OnNameChanging(value As Global.System.String)
        End Sub
    
        Private Partial Sub OnNameChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
        <DataMemberAttribute()>
        Public Property UserName() As Global.System.String
            Get
                Return _UserName
            End Get
            Set
                OnUserNameChanging(value)
                ReportPropertyChanging("UserName")
                _UserName = StructuralObject.SetValidValue(value, true)
                ReportPropertyChanged("UserName")
                OnUserNameChanged()
            End Set
        End Property
    
        Private _UserName As Global.System.String
        Private Partial Sub OnUserNameChanging(value As Global.System.String)
        End Sub
    
        Private Partial Sub OnUserNameChanged()
        End Sub

        #End Region
        #Region "Navigation Properties"
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <XmlIgnoreAttribute()>
        <SoapIgnoreAttribute()>
        <DataMemberAttribute()>
        <EdmRelationshipNavigationPropertyAttribute("PlanetWroxModel", "FK_Picture_PhotoAlbum", "Picture")>
         Public Property Pictures() As EntityCollection(Of Picture)
            Get
                Return CType(Me,IEntityWithRelationships).RelationshipManager.GetRelatedCollection(Of Picture)("PlanetWroxModel.FK_Picture_PhotoAlbum", "Picture")
            End Get
            Set
                If (Not value Is Nothing)
                    CType(Me, IEntityWithRelationships).RelationshipManager.InitializeRelatedCollection(Of Picture)("PlanetWroxModel.FK_Picture_PhotoAlbum", "Picture", value)
                End If
            End Set
        End Property

        #End Region
    End Class
    
    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmEntityTypeAttribute(NamespaceName:="PlanetWroxModel", Name:="Picture")>
    <Serializable()>
    <DataContractAttribute(IsReference:=True)>
    Public Partial Class Picture
        Inherits EntityObject
        #Region "Factory Method"
    
        ''' <summary>
        ''' Create a new Picture object.
        ''' </summary>
        ''' <param name="id">Initial value of the Id property.</param>
        ''' <param name="description">Initial value of the Description property.</param>
        ''' <param name="toolTip">Initial value of the ToolTip property.</param>
        ''' <param name="imageUrl">Initial value of the ImageUrl property.</param>
        ''' <param name="photoAlbumId">Initial value of the PhotoAlbumId property.</param>
        Public Shared Function CreatePicture(id As Global.System.Int32, description As Global.System.String, toolTip As Global.System.String, imageUrl As Global.System.String, photoAlbumId As Global.System.Int32) As Picture
            Dim picture as Picture = New Picture
            picture.Id = id
            picture.Description = description
            picture.ToolTip = toolTip
            picture.ImageUrl = imageUrl
            picture.PhotoAlbumId = photoAlbumId
            Return picture
        End Function

        #End Region
        #Region "Primitive Properties"
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property Id() As Global.System.Int32
            Get
                Return _Id
            End Get
            Set
                If (_Id <> Value) Then
                    OnIdChanging(value)
                    ReportPropertyChanging("Id")
                    _Id = StructuralObject.SetValidValue(value)
                    ReportPropertyChanged("Id")
                    OnIdChanged()
                End If
            End Set
        End Property
    
        Private _Id As Global.System.Int32
        Private Partial Sub OnIdChanging(value As Global.System.Int32)
        End Sub
    
        Private Partial Sub OnIdChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property Description() As Global.System.String
            Get
                Return _Description
            End Get
            Set
                OnDescriptionChanging(value)
                ReportPropertyChanging("Description")
                _Description = StructuralObject.SetValidValue(value, false)
                ReportPropertyChanged("Description")
                OnDescriptionChanged()
            End Set
        End Property
    
        Private _Description As Global.System.String
        Private Partial Sub OnDescriptionChanging(value As Global.System.String)
        End Sub
    
        Private Partial Sub OnDescriptionChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property ToolTip() As Global.System.String
            Get
                Return _ToolTip
            End Get
            Set
                OnToolTipChanging(value)
                ReportPropertyChanging("ToolTip")
                _ToolTip = StructuralObject.SetValidValue(value, false)
                ReportPropertyChanged("ToolTip")
                OnToolTipChanged()
            End Set
        End Property
    
        Private _ToolTip As Global.System.String
        Private Partial Sub OnToolTipChanging(value As Global.System.String)
        End Sub
    
        Private Partial Sub OnToolTipChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property ImageUrl() As Global.System.String
            Get
                Return _ImageUrl
            End Get
            Set
                OnImageUrlChanging(value)
                ReportPropertyChanging("ImageUrl")
                _ImageUrl = StructuralObject.SetValidValue(value, false)
                ReportPropertyChanged("ImageUrl")
                OnImageUrlChanged()
            End Set
        End Property
    
        Private _ImageUrl As Global.System.String
        Private Partial Sub OnImageUrlChanging(value As Global.System.String)
        End Sub
    
        Private Partial Sub OnImageUrlChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property PhotoAlbumId() As Global.System.Int32
            Get
                Return _PhotoAlbumId
            End Get
            Set
                OnPhotoAlbumIdChanging(value)
                ReportPropertyChanging("PhotoAlbumId")
                _PhotoAlbumId = StructuralObject.SetValidValue(value)
                ReportPropertyChanged("PhotoAlbumId")
                OnPhotoAlbumIdChanged()
            End Set
        End Property
    
        Private _PhotoAlbumId As Global.System.Int32
        Private Partial Sub OnPhotoAlbumIdChanging(value As Global.System.Int32)
        End Sub
    
        Private Partial Sub OnPhotoAlbumIdChanged()
        End Sub

        #End Region
        #Region "Navigation Properties"
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <XmlIgnoreAttribute()>
        <SoapIgnoreAttribute()>
        <DataMemberAttribute()>
        <EdmRelationshipNavigationPropertyAttribute("PlanetWroxModel", "FK_Picture_PhotoAlbum", "PhotoAlbum")>
        Public Property PhotoAlbum() As PhotoAlbum
            Get
                Return CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of PhotoAlbum)("PlanetWroxModel.FK_Picture_PhotoAlbum", "PhotoAlbum").Value
            End Get
            Set
                CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of PhotoAlbum)("PlanetWroxModel.FK_Picture_PhotoAlbum", "PhotoAlbum").Value = value
            End Set
        End Property
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <BrowsableAttribute(False)>
        <DataMemberAttribute()>
        Public Property PhotoAlbumReference() As EntityReference(Of PhotoAlbum)
            Get
                Return CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of PhotoAlbum)("PlanetWroxModel.FK_Picture_PhotoAlbum", "PhotoAlbum")
            End Get
            Set
                If (Not value Is Nothing)
                    CType(Me, IEntityWithRelationships).RelationshipManager.InitializeRelatedReference(Of PhotoAlbum)("PlanetWroxModel.FK_Picture_PhotoAlbum", "PhotoAlbum", value)
                End If
            End Set
        End Property

        #End Region
    End Class
    
    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmEntityTypeAttribute(NamespaceName:="PlanetWroxModel", Name:="Review")>
    <Serializable()>
    <DataContractAttribute(IsReference:=True)>
    Public Partial Class Review
        Inherits EntityObject
        #Region "Factory Method"
    
        ''' <summary>
        ''' Create a new Review object.
        ''' </summary>
        ''' <param name="id">Initial value of the Id property.</param>
        ''' <param name="title">Initial value of the Title property.</param>
        ''' <param name="summary">Initial value of the Summary property.</param>
        ''' <param name="genreId">Initial value of the GenreId property.</param>
        ''' <param name="authorized">Initial value of the Authorized property.</param>
        ''' <param name="createDateTime">Initial value of the CreateDateTime property.</param>
        ''' <param name="updateDateTime">Initial value of the UpdateDateTime property.</param>
        Public Shared Function CreateReview(id As Global.System.Int32, title As Global.System.String, summary As Global.System.String, genreId As Global.System.Int32, authorized As Global.System.Boolean, createDateTime As Global.System.DateTime, updateDateTime As Global.System.DateTime) As Review
            Dim review as Review = New Review
            review.Id = id
            review.Title = title
            review.Summary = summary
            review.GenreId = genreId
            review.Authorized = authorized
            review.CreateDateTime = createDateTime
            review.UpdateDateTime = updateDateTime
            Return review
        End Function

        #End Region
        #Region "Primitive Properties"
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property Id() As Global.System.Int32
            Get
                Return _Id
            End Get
            Set
                If (_Id <> Value) Then
                    OnIdChanging(value)
                    ReportPropertyChanging("Id")
                    _Id = StructuralObject.SetValidValue(value)
                    ReportPropertyChanged("Id")
                    OnIdChanged()
                End If
            End Set
        End Property
    
        Private _Id As Global.System.Int32
        Private Partial Sub OnIdChanging(value As Global.System.Int32)
        End Sub
    
        Private Partial Sub OnIdChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property Title() As Global.System.String
            Get
                Return _Title
            End Get
            Set
                OnTitleChanging(value)
                ReportPropertyChanging("Title")
                _Title = StructuralObject.SetValidValue(value, false)
                ReportPropertyChanged("Title")
                OnTitleChanged()
            End Set
        End Property
    
        Private _Title As Global.System.String
        Private Partial Sub OnTitleChanging(value As Global.System.String)
        End Sub
    
        Private Partial Sub OnTitleChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property Summary() As Global.System.String
            Get
                Return _Summary
            End Get
            Set
                OnSummaryChanging(value)
                ReportPropertyChanging("Summary")
                _Summary = StructuralObject.SetValidValue(value, false)
                ReportPropertyChanged("Summary")
                OnSummaryChanged()
            End Set
        End Property
    
        Private _Summary As Global.System.String
        Private Partial Sub OnSummaryChanging(value As Global.System.String)
        End Sub
    
        Private Partial Sub OnSummaryChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
        <DataMemberAttribute()>
        Public Property Body() As Global.System.String
            Get
                Return _Body
            End Get
            Set
                OnBodyChanging(value)
                ReportPropertyChanging("Body")
                _Body = StructuralObject.SetValidValue(value, true)
                ReportPropertyChanged("Body")
                OnBodyChanged()
            End Set
        End Property
    
        Private _Body As Global.System.String
        Private Partial Sub OnBodyChanging(value As Global.System.String)
        End Sub
    
        Private Partial Sub OnBodyChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property GenreId() As Global.System.Int32
            Get
                Return _GenreId
            End Get
            Set
                OnGenreIdChanging(value)
                ReportPropertyChanging("GenreId")
                _GenreId = StructuralObject.SetValidValue(value)
                ReportPropertyChanged("GenreId")
                OnGenreIdChanged()
            End Set
        End Property
    
        Private _GenreId As Global.System.Int32
        Private Partial Sub OnGenreIdChanging(value As Global.System.Int32)
        End Sub
    
        Private Partial Sub OnGenreIdChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property Authorized() As Global.System.Boolean
            Get
                Return _Authorized
            End Get
            Set
                OnAuthorizedChanging(value)
                ReportPropertyChanging("Authorized")
                _Authorized = StructuralObject.SetValidValue(value)
                ReportPropertyChanged("Authorized")
                OnAuthorizedChanged()
            End Set
        End Property
    
        Private _Authorized As Global.System.Boolean
        Private Partial Sub OnAuthorizedChanging(value As Global.System.Boolean)
        End Sub
    
        Private Partial Sub OnAuthorizedChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property CreateDateTime() As Global.System.DateTime
            Get
                Return _CreateDateTime
            End Get
            Set
                OnCreateDateTimeChanging(value)
                ReportPropertyChanging("CreateDateTime")
                _CreateDateTime = StructuralObject.SetValidValue(value)
                ReportPropertyChanged("CreateDateTime")
                OnCreateDateTimeChanged()
            End Set
        End Property
    
        Private _CreateDateTime As Global.System.DateTime
        Private Partial Sub OnCreateDateTimeChanging(value As Global.System.DateTime)
        End Sub
    
        Private Partial Sub OnCreateDateTimeChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property UpdateDateTime() As Global.System.DateTime
            Get
                Return _UpdateDateTime
            End Get
            Set
                OnUpdateDateTimeChanging(value)
                ReportPropertyChanging("UpdateDateTime")
                _UpdateDateTime = StructuralObject.SetValidValue(value)
                ReportPropertyChanged("UpdateDateTime")
                OnUpdateDateTimeChanged()
            End Set
        End Property
    
        Private _UpdateDateTime As Global.System.DateTime
        Private Partial Sub OnUpdateDateTimeChanging(value As Global.System.DateTime)
        End Sub
    
        Private Partial Sub OnUpdateDateTimeChanged()
        End Sub

        #End Region
        #Region "Navigation Properties"
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <XmlIgnoreAttribute()>
        <SoapIgnoreAttribute()>
        <DataMemberAttribute()>
        <EdmRelationshipNavigationPropertyAttribute("PlanetWroxModel", "FK_Review_Genre", "Genre")>
        Public Property Genre() As Genre
            Get
                Return CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of Genre)("PlanetWroxModel.FK_Review_Genre", "Genre").Value
            End Get
            Set
                CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of Genre)("PlanetWroxModel.FK_Review_Genre", "Genre").Value = value
            End Set
        End Property
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <BrowsableAttribute(False)>
        <DataMemberAttribute()>
        Public Property GenreReference() As EntityReference(Of Genre)
            Get
                Return CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of Genre)("PlanetWroxModel.FK_Review_Genre", "Genre")
            End Get
            Set
                If (Not value Is Nothing)
                    CType(Me, IEntityWithRelationships).RelationshipManager.InitializeRelatedReference(Of Genre)("PlanetWroxModel.FK_Review_Genre", "Genre", value)
                End If
            End Set
        End Property

        #End Region
    End Class

    #End Region
    
End Namespace
