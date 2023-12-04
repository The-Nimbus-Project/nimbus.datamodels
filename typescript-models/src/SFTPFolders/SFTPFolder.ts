export interface SFTPFolder {
    /**
     * MongoDB ObjectId
     */
    _id?:      string;
    name?:     string;
    path?:     string;
    patterns?: SFTPFolderPattern[];
    /**
     * MongoDB ObjectId
     */
    sftp_id?: string;
    [property: string]: any;
}

export interface SFTPFolderPattern {
    /**
     * MongoDB ObjectId
     */
    _id?:           string;
    descriptor?:    string;
    fileType?:      string;
    regexPatterns?: string[];
    [property: string]: any;
}
